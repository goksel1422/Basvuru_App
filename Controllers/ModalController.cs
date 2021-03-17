using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Basvuru_App.Models;
using System.IO;

namespace Basvuru_App.Controllers
{
    public class ModalController : Controller
    {
        basvuruEntities db = new basvuruEntities();
        // GET: Modal


        [HttpGet]
        public ActionResult SertifikaModal()
        { 
            return PartialView();
        }

        [HttpGet]
        public ActionResult DeneyimModal()
        {
            var degerIller = db.iller.ToList();
            return PartialView(degerIller);
        }
        [HttpGet]
        public ActionResult SeminerModal()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult ProjeModal()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult YabanciDilModal()
        {
            ViewBag.DillerViewBag = db.diller.ToList();
            var degerSeviyeler = db.basari_seviyeleri.ToList();
            return PartialView(degerSeviyeler);
        }
        [HttpGet]
        public ActionResult ReferansModal()
        {
            return PartialView();
        }
    }
}