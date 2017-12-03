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
    public class PersonelController : Controller
    {
        // GET: Personel
        PersonelManager permanager = new PersonelManager();
        UnvanManager unvmanager = new UnvanManager();
        EgitimManager egtmanager = new EgitimManager();
        BolumManager bolmanager = new BolumManager();
        IlManager ilmanager = new IlManager();
        IlceManager ilcemanager = new IlceManager();
        PersonelModel model = new PersonelModel();
        public ActionResult Personel()
        {
            PersonelModel model = new PersonelModel();
            model.list = permanager.PersonelDtoListele().ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            PersonelModel model = new PersonelModel();
            model.BolumForDropdown = BolumDropdownDoldur();
            model.UnvanForDropdown = UnvanDropdownDoldur();
            model.EgitimDropdown = EgitimDropdownDoldur();
            model.IlceForDropdown = IlceDropdownDoldur();
            model.IlForDropdown = IlDropdownDoldur();
            model.YoneticiForDropDown = YoneticiDropdownDoldur();
            return View(model);
        }
        [HttpPost]
        public ActionResult Ekle(PersonelModel pm)
        {
            Personel per = new Personel();
            per.BolumId = pm.personel.BolumId;
            per.EgitimId = pm.personel.EgitimId;
            per.UnvanId = pm.personel.UnvanId;
            per.Telno = pm.personel.Telno;
            per.Maas = pm.personel.Maas;
            per.Email = pm.personel.Email;
            per.DogumTarihi = pm.personel.DogumTarihi;
            per.YoneticiId = pm.personel.YoneticiId;
            per.Yoneticimi = pm.personel.Yoneticimi;
            per.IlceId = pm.personel.IlceId;
            per.Ilce.IlId = pm.personel.Ilce.IlId;
            per.PersonelAd = pm.personel.PersonelAd;
            per.PersonelSoyad = pm.personel.PersonelSoyad;
            permanager.Ekle(per);
            permanager.Save();
            return RedirectToAction("Personel");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            PersonelModel model = new PersonelModel();
            model.personel = permanager.Bul(id);
            model.BolumForDropdown = BolumDropdownDoldur();
            model.UnvanForDropdown = UnvanDropdownDoldur();
            model.EgitimDropdown = EgitimDropdownDoldur();
            model.IlceForDropdown = IlceDropdownDoldur();
            model.IlForDropdown = IlDropdownDoldur();
            model.YoneticiForDropDown = YoneticiDropdownDoldur();
            return View(model);

        }
        [HttpPost]
        public ActionResult Guncelle(int id, PersonelModel pm)
        {
            Personel per = permanager.Bul(id);
            per.BolumId = pm.personel.BolumId;
            per.EgitimId = pm.personel.EgitimId;
            per.UnvanId = pm.personel.UnvanId;
            per.Telno = pm.personel.Telno;
            per.Maas = pm.personel.Maas;
            per.Email = pm.personel.Email;
            per.DogumTarihi = pm.personel.DogumTarihi;
            per.YoneticiId = pm.personel.YoneticiId;
            per.Yoneticimi = pm.personel.Yoneticimi;
            per.IlceId = pm.personel.IlceId;
            per.Ilce.IlId = pm.personel.Ilce.IlId;
            per.PersonelAd = pm.personel.PersonelAd;
            per.PersonelSoyad = pm.personel.PersonelSoyad;
            permanager.Guncelle(per);
            permanager.Save();
            return RedirectToAction("Personel");
        }
        public ActionResult Detay(int id)
        {
            Personel p = permanager.Bul(id);
            PersonelModel model = new PersonelModel();
            model.personel = p;
            return View(model);

        }
        public ActionResult Sil(int id)
        {
            Personel personel = permanager.Bul(id);
            permanager.Sil(personel);
            permanager.Save();
            return RedirectToAction("Personel");
        }
        public List<SelectListItem> BolumDropdownDoldur()
        {
            return bolmanager.Listele().Select(x => new SelectListItem()
            {
                Text = x.Ad,
                Value = x.Id.ToString()
            }).ToList();
        }
        public List<SelectListItem> EgitimDropdownDoldur()
        {
            return egtmanager.Listele().Select(x => new SelectListItem()
            {
                Text = x.Ad,
                Value = x.Id.ToString()
            }).ToList();
        }
        public List<SelectListItem> UnvanDropdownDoldur()
        {
            return unvmanager.Listele().Select(x => new SelectListItem()
            {
                Text = x.Ad,
                Value = x.Id.ToString()
            }).ToList();
        }
        public List<SelectListItem> IlDropdownDoldur()
        {
            return ilmanager.Listele().Select(x => new SelectListItem()
            {
                Text = x.IlAd,
                Value = x.IlId.ToString()
            }).ToList();
        }
        public List<SelectListItem> IlceDropdownDoldur()
        {
            return ilcemanager.Listele().Select(x => new SelectListItem()
            {
                Text = x.Ad,
                Value = x.Id.ToString()
            }).ToList();
        }
        public List<SelectListItem> YoneticiDropdownDoldur()
        {
            return permanager.Listele().Select(x => new SelectListItem()
            {
                Text = x.PersonelAd + " " + x.PersonelSoyad,
                Value = x.PersonelId.ToString(),
            }).ToList();
        }

        //private void DropDownDoldur(PersonelModel model)
        //{
        //    model.BolumForDropdown = bolmanager.Set().Select(x => new SelectListItem()
        //    {
        //        Text = x.Ad,
        //        Value = x.Id.ToString()
        //    }).ToList();
        //    model.EgitimDropdown = egtmanager.Set().Select(x => new SelectListItem()
        //    {
        //        Text = x.Ad,
        //        Value = x.Id.ToString()
        //    }).ToList();
        //    model.UnvanForDropdown = unvmanager.Set().Select(x => new SelectListItem()
        //    {
        //        Text = x.Ad,
        //        Value = x.Id.ToString()
        //    }).ToList();
        //    model.IlForDropdown = ilmanager.Set().Select(x => new SelectListItem()
        //    {
        //        Text = x.IlAd,
        //        Value = x.IlId.ToString()
        //    }).ToList();
        //    model.IlceForDropdown = ilcemanager.Set().Select(x => new SelectListItem()
        //    {
        //        Text = x.Ad,
        //        Value = x.Id.ToString()
        //    }).ToList();

        //    model.YoneticiForDropDown = permanager.Set().Select(x => new SelectListItem()
        //    {
        //        Text = x.PersonelAd + " " + x.PersonelSoyad,
        //        Value = x.PersonelId.ToString(),


        //    }).ToList();
        }
    }
    
