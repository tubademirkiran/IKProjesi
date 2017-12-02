namespace IKProjesi.DL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using static IKProjesi.ENT.Entities;

    public class IKContext : DbContext
    {
        
        public IKContext()
            : base("Baglanti")
        {
        }

        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }
        public virtual DbSet<Bolum> Bolum { get; set; }
        public virtual DbSet<Egitim> Egitim { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Il> Il { get; set; }

    }

   
}