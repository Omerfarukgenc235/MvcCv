using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;
namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        public ActionResult Index()
        {
            var sosyal = repo.List();
            return View(sosyal);
        }
        [HttpGet]
        public ActionResult YeniSosyal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSosyal(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult SosyalGetir(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SosyalGetir(TblSosyalMedya p)
        {
            var hesap = repo.Find(x => x.ID == p.ID);
            hesap.Ad = p.Ad;
            hesap.Link = p.Link;
            hesap.Icon = p.Icon;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult SosyalSil(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            repo.TDelete(hesap);
            return RedirectToAction("Index");

        }
    }
}