using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Models.View
{
    public class IlModel
    {
        public IEnumerable<Il> list { get; set; }
        public Il il { get; set; }
    }
}