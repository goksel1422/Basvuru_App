using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Basvuru_App.Models;
using System.IO;

namespace Basvuru_App.Controllers
{
    public class UyeGirisController : Controller
    {
        basvuruEntities db = new basvuruEntities();
        // GET: UyeGiris
        public ActionResult UyeGiris()
        {
            Session.RemoveAll();
            Session.Clear();
            Session.Abandon();
            return View();
        }
        [HttpPost]
        public ActionResult UyeGiris(string KulEposta, string KulPass)
        {
            var obj = db.kullanicilar.Where(a => a.KEposta.Equals(KulEposta) && a.KSifre.Equals(KulPass)).FirstOrDefault();
            if (obj != null)
            {
                var degerler = db.kullanicilar.ToList();

                Session.Add("ActiveUserAdi", obj.KAdi);
                Session.Add("ActiveUserSoyAdi", obj.KSoyad);
                Session.Add("ActiveUserKID", obj.KID);
                Session.Add("ActiveUserYetki", obj.YetkiID);
                Session.Add("ActiveUserYetkiAdi", obj.yetkiler.Yetki);
                Session.Add("ActiveUserResim", obj.KResim);


                if (obj.YetkiID == 1)
                {
                    return RedirectToAction("basvuruListele", "Admin");
                }
                else if (obj.YetkiID == 2)
                {
                    return RedirectToAction("BasvuruDurum", "Kullanici");
                }
            }

            return View();
        }
        public ActionResult YeniUye()
        {
            return View("YeniUye");
        }

        [HttpPost]
        public ActionResult YeniUye(kullanicilar p1, System.Web.HttpPostedFileBase yuklenecekDosya)
        {
            if (yuklenecekDosya != null)
            {
                var supportedTypes = new[] { "jpg", "jpeg", "png" };

                var fileExt = System.IO.Path.GetExtension(yuklenecekDosya.FileName).Substring(1);

                if (!supportedTypes.Contains(fileExt))
                {


                    return RedirectToAction("UyeGiris");
                }

                string dosyaYolu = Guid.NewGuid() + "." + fileExt;
                var yuklemeYeri = Path.Combine(Server.MapPath("~/KlcDosyalar"), dosyaYolu);
                yuklenecekDosya.SaveAs(yuklemeYeri);

                p1.KResim = dosyaYolu;
            }
            else
            {
                if (p1.KCinsiyet == true)
                {
                    p1.KResim = "Erkek.png";
                }
                else
                {
                    p1.KResim = "Kadin.png";
                }

            }
            p1.YetkiID = 2;
            db.kullanicilar.Add(p1);
            db.SaveChanges();
            return RedirectToAction("UyeGiris");
        }
    }
}