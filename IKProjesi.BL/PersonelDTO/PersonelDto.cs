using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesi.BL.PersonelDTO
{
    public class PersonelDto
    {
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string Unvan { get; set; }
        public int IlceId { get; set; }
        public int IlId { get; set; }

    }
}
