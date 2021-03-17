using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Basvuru_App.Models;
using System.IO;

namespace Basvuru_App.Controllers
{
    public class PartialController : Controller
    {
        basvuruEntities db = new basvuruEntities();
        // GET: Partial

        public ActionResult SertifikaPartial()
        {
            return PartialView();
        }
        public ActionResult DeneyimPartial()
        {
            return PartialView();
        }
        public ActionResult SeminerPartial()
        {
            return PartialView();
        }
        public ActionResult ProjePartial()
        {
            return PartialView();
        }
        public ActionResult YabanciDilPartial()
        {
            return PartialView();
        }  
        public ActionResult ReferansPartial()
        {
            return PartialView();
        }
        public ActionResult BasvuruVeriPartial()
        {
            var degerUni = db.universiteler.ToList();
            ViewBag.AskerlikViewBag = db.askerlik.ToList();
            TempData["askerlikDurum"] = db.kullanicilar.Find(Convert.ToInt32(Session["ActiveUserKID"])).KCinsiyet;
            return PartialView(degerUni);
        }

        [HttpGet]
        public JsonResult MeslekGetir(string Prefix)
        {

            var meslekListe = db.meslekler.Where(x => x.isim.ToLower().Contains(Prefix.ToLower())).ToList();

            var altkategoris = meslekListe.Select(y => new
            {
                value = y.isim.ToString(),
                title = y.MeslekID
            }).ToList();


            return Json(altkategoris, JsonRequestBehavior.AllowGet);

        }

        public JsonResult FakulteGetir(int UniID)
        {
            var model = db.fakulteler.Where(f => f.uni_id == UniID).ToList();

            var fakulteData = model.Select(m => new SelectListItem()
            {
                Text = m.fakulte_ad,
                Value = m.fakulte_id.ToString(),
            });
            return Json(fakulteData, JsonRequestBehavior.AllowGet);

        }
        public JsonResult BolumGetir(int BolumID)
        {
            var model = db.bolumler.Where(f => f.fakulte_id == BolumID).ToList();

            var bolumData = model.Select(m => new SelectListItem()
            {
                Text = m.bolum_ad,
                Value = m.bolum_id.ToString(),
            });
            return Json(bolumData, JsonRequestBehavior.AllowGet);

        }
    }
}