using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Basvuru_App.Models;
using System.IO;
using System.Threading.Tasks;

namespace Basvuru_App.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        basvuruEntities db = new basvuruEntities();
        public ActionResult BasvuruDurum()
        {
            int KID = Convert.ToInt32(Session["ActiveUserKID"]);
            var KBasvuru = db.basvurular.Where(m => m.KID == KID).ToList();
            int durumDeger = KBasvuru.Where(m => m.BDurumID == 1 || m.BDurumID == 2).Count();
            if ( durumDeger != 0) {

                TempData["Bilgi"] = "Görüntülenmiş veya Beklemede olan basvurularınız var.";
                return View(KBasvuru);
            }

            TempData["Bilgi"] = null;

            return View(KBasvuru);
        }
        public ActionResult YeniBasvuru()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBasvuruEkle(basvurular b1)
        {
            b1.KID = Convert.ToInt32(Session["ActiveUserKID"]);
            b1.BDurumID = 1;
            db.basvurular.Add(b1);
            db.SaveChanges();
            return RedirectToAction("BasvuruDurum");
        }

    }
}