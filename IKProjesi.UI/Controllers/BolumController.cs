using IKProjesi.UI.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IKProjesi.BL.BusinessManager;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Controllers
{
    public class BolumController : Controller
    {
        // GET: Bolum
        BolumModel model = new BolumModel();
        BolumManager manager = new BolumManager();
        public ActionResult Bolum()
        {
            model.list = manager.GenelListe();
            return View(model);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(BolumModel model)
        {
            Bolum bolum = new Bolum();
            bolum.Ad = model.bolum.Ad;
            manager.Ekle(bolum);
            manager.Save();
            return RedirectToAction("Bolum");
            
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            model.bolum = manager.Bul(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Guncelle(int id,BolumModel model)
        {
            Bolum bolum = manager.Bul(id);
            bolum.Ad = model.bolum.Ad;
            manager.Guncelle(bolum);
            manager.Save();
            return RedirectToAction("Bolum");
        }
        public ActionResult Detay(int id)
        {
            model.bolum = manager.Bul(id);
            return View(model);
        }
        public ActionResult Sil(int id)
        {
            Bolum bolum = manager.Bul(id);
            manager.Sil(bolum);
            manager.Save();
            return RedirectToAction("Bolum");
        }
    }
}