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
    public class IlceController : Controller
    {
        // GET: Ilce
        IlceModel model = new IlceModel();
        IlceManager manager = new IlceManager();
        IlManager ilmanager = new IlManager();
        public ActionResult Ilce()
        {
            model.list = manager.GenelListe();
            model.IlForDropdown = DropdownDoldur();
            return View(model);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            model.IlForDropdown = DropdownDoldur();
            return View(model);
        }
        [HttpPost]
        public ActionResult Ekle(IlceModel model)
        {
            Ilce ilce = new Ilce();
            ilce.Ad = model.ilce.Ad;
            ilce.IlId = model.ilce.IlId;
            manager.Ekle(ilce);
            manager.Save();
            return RedirectToAction("Ilce");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            model.ilce = manager.Bul(id);
            model.IlForDropdown = DropdownDoldur();
            return View(model);
        }
        [HttpPost]
        public ActionResult Guncelle(int id, IlceModel model)
        {
            Ilce ilce = manager.Bul(id);
            ilce.Ad = model.ilce.Ad;
            ilce.IlId = model.ilce.IlId;
            manager.Guncelle(ilce);
            manager.Save();
            return RedirectToAction("Ilce");
        }
        public ActionResult Detay(int id)
        {
            model.ilce = manager.Bul(id);
            return View(model);
        }
        public ActionResult Sil(int id, IlceModel model)
        {
            Ilce ilce = manager.Bul(id);
            manager.Sil(ilce);
            manager.Save();
            return RedirectToAction("Ilce");
        }



        public List<SelectListItem> DropdownDoldur()
        {
            return ilmanager.Listele().Select(x => new SelectListItem
            {
                Text = x.IlAd,
                Value = x.IlId.ToString()
            }).ToList();
        }
    }
}