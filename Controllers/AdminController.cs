using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Basvuru_App.Models;
using System.IO;

namespace Basvuru_App.Controllers
{
    public class AdminController : Controller
    {
        basvuruEntities db = new basvuruEntities();
        // GET: Admin
        //fghfghfcgh
        public ActionResult basvuruListele()
        {
            var Bdeger = db.basvurular.ToList();
            var deger0 = Bdeger.Where(m => m.BDurumID == 1).ToList();
            ViewBag.BGorViewBag = Bdeger.Where(m => m.BDurumID == 2).ToList();
            ViewBag.BOnyRedViewBag = Bdeger.Where(m => m.BDurumID >= 3).ToList();

            return View(deger0);
        }
        [HttpGet]
        public ActionResult basvuruIncele(int id)
        {
            var deger = db.basvurular.Find(id);
            if (deger.BDurumID == 1)
            {
                deger.BDurumID = 2;      
            db.Entry(deger).CurrentValues.SetValues(deger);
            db.SaveChanges();
            }

            var basvurular = db.basvurular.Where(m => m.KID == deger.KID).ToList();
            foreach (var bsr in basvurular)
            {
                if (bsr.BDurumID == 3)
                {
                    TempData["onayUyari"] = bsr.kullanicilar.KAdi + " " + bsr.kullanicilar.KSoyad + " adayının" +" "+ bsr.meslekler.isim + " olarak basvurusunu onalyadınız. Lütfen bu başvuru reddedip tekrar deneyin...";
                }
            }
            var refereans = db.referanslar.Where(m => m.BID == id).ToList();
            TempData["RefSay"] = refereans.Count();
            return View(deger);
        }
        [HttpGet]
        public ActionResult BasvuruOnay(int BID)
        {
            var basvuru = db.basvurular.Find(BID);
            basvuru.BDurumID = 3;
            db.Entry(basvuru).CurrentValues.SetValues(basvuru);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult BasvuruRed(int BID)
        {
            var basvuru = db.basvurular.Find(BID);
            basvuru.BDurumID = 4;
            db.Entry(basvuru).CurrentValues.SetValues(basvuru);
            db.SaveChanges();
            return View();
        }
        public ActionResult PersonelListele()
        {
            var ListeDeger = db.basvurular.ToList();
            var OnayDeger = ListeDeger.Where(m => m.BDurumID == 3).ToList();     
            ViewBag.RedDegerViewBag = ListeDeger.Where(m => m.BDurumID == 4).ToList();
            return View(OnayDeger);
        }
        public ActionResult PersonelIncele(int id)
        {
            var deger = db.basvurular.Find(id);
            var basvurular = db.basvurular.Where(m => m.KID == deger.KID).ToList();
            var refereans = db.referanslar.Where(m => m.BID == id).ToList();
            TempData["RefSay"] = refereans.Count();
            return View(deger);
        }
        public ActionResult YeniBasvuruAdmin()
        {
            var kisi = db.kullanicilar.ToList();
            return View(kisi);
        }
        public ActionResult YeniBasvuruAdminEkle(basvurular b1)
        {
            b1.BDurumID = 2;
            db.basvurular.Add(b1);
            db.SaveChanges();
            return RedirectToAction("basvuruListele");
        }
    }
}