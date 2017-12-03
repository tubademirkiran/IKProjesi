using IKProjesi.BL.PersonelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IKProjesi.REP.Repositories;

namespace IKProjesi.BL
{
    public class BusinessManager
    {
        public class PersonelManager : PersonelRepositories
        {
            public List<PersonelDto> PersonelDtoListele()
            {
                return GenelListe().Select(x => new PersonelDto
                {
                    PersonelId=x.PersonelId,
                    PersonelAd=x.PersonelAd,
                    PersonelSoyad=x.PersonelSoyad,
                    Unvan=x.Unvan.Ad,
                    IlceId=x.IlceId,
                    IlId=x.Ilce.IlId
                }).ToList();
            }
           
        }
        public class UnvanManager : UnvanRepositories { }
        public class EgitimManager : EgitimRepositories { }
        public class IlManager : IlRepositories { }
        public class BolumManager : BolumRepositories { }
        public class IlceManager : IlceRepositories { }
    }
}
