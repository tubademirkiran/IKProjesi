using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Models.View
{
    public class UnvanModel
    {
        public IEnumerable<Unvan> list{ get; set; }
        public Unvan unvan { get; set; }

    }
}