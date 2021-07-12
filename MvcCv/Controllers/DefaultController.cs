using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities2 db = new DbCvEntities2();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyal = db.TblSosyalMedya.ToList();
            return PartialView(sosyal);
        }
        public PartialViewResult Deneyim()
        {
            var degerler = db.TblDeneyimlerim.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Egitimlerim()
        {
            var degerler = db.TblEgitimlerim.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var degerler = db.TblYetenekler.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Hobilerim()
        {
            var degerler = db.TblHobilerim.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Sertifikalar()
        {
            var degerler = db.TblSertifikalarim.ToList();
            return PartialView(degerler);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(Tbliletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}