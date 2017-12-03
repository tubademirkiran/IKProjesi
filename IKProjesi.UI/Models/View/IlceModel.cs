using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Models.View
{
    public class IlceModel
    {
        public IEnumerable<Ilce> list { get; set; }
        public Ilce ilce { get; set; }
        public List<SelectListItem> IlForDropdown { get; set; }

    }
}