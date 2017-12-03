using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.REP
{
    public class Repositories
    {
        //Temel metotlara tabloların referans verileceği classtır.
        public class PersonelRepositories : BaseRepository<Personel> { }
        public class UnvanRepositories : BaseRepository<Unvan> { }
        public class BolumRepositories : BaseRepository<Bolum> { }
        public class EgitimRepositories : BaseRepository<Egitim> { }
        public class IlRepositories : BaseRepository<Il> { }
        public class IlceRepositories : BaseRepository<Ilce> { }


    }
}
