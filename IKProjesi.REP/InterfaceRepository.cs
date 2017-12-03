using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesi.REP
{
    interface InterfaceRepository<T> where T:class,new()
    {
        DbSet<T> Set();//T bir class ve bu class veri tabanından bir tablo taşır.
        void Sil(T entity); //entity T classından yani tablodan bir nesnedir
        void Ekle(T entity);
        T Bul(int id);
        T Bul(string id);
        void Guncelle(T entity);
        void Save();
        IQueryable<T> GenelListe();

    }
}
