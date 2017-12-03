using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Models.View
{
    public class BolumModel
    {
        public IEnumerable<Bolum> list { get; set; }
        public Bolum bolum { get; set; }

    }
}