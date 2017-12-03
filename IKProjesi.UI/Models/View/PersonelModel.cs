using IKProjesi.BL.PersonelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Models.View
{
    public class PersonelModel
    {
        public IEnumerable<PersonelDto> list { get; set; }
        public Personel personel { get; set; }
        public List<SelectListItem> IlForDropdown { get; set; }
        public List<SelectListItem> IlceForDropdown { get; set; }
        public List<SelectListItem> UnvanForDropdown { get; set; }
        public List<SelectListItem> EgitimDropdown { get; set; }
        public List<SelectListItem> BolumForDropdown { get; set; }
        public List<SelectListItem> YoneticiForDropDown { get; set; }
    }
}