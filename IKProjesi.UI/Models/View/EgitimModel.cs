using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Models.View
{
    public class EgitimModel
    {
        public IEnumerable<Egitim> list { get; set; }
        public Egitim egitim { get; set; }

    }
}