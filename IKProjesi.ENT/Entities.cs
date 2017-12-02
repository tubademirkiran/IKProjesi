using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesi.ENT
{
    public class Entities
    {
        [Table("Personel")]
        public class Personel
        {
            public int PersonelId { get; set; }
            public string PersonelAd { get; set; }
            public string PersonelSoyad { get; set; }
            public decimal Maas { get; set; }
            public string Email { get; set; }
            public int Telno { get; set; }
            public DateTime DogumTarihi { get; set; }
            public int IlceId { get; set; }
            public int BolumId { get; set; }
            public int UnvanId { get; set; }
            public int EgitimId { get; set; }
            public int? YoneticiId { get; set; }
            public Boolean Yoneticimi { get; set; }

            [ForeignKey("BolumId")]
            public virtual Bolum Bolum { get; set; }
            [ForeignKey("UnvanId")]
            public virtual Unvan Unvan { get; set; }
            [ForeignKey("EgitimId")]
            public virtual Egitim Egitim { get; set; }
            [ForeignKey("IlceId")]
            public virtual Ilce Ilce { get; set; }
            [ForeignKey("YoneticiId")]
            public virtual Personel Yonetici { get; set; }
            public virtual ICollection<Personel> Eleman { get; set; }

        }
        public class Tanimlar
        {
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }
            public virtual ICollection<Personel> Personel { get; set; }
            //Bu class ın amacı tekrar eden bütün class ların ortak olanlarını bir yerde toplayıp kalıtım vermek
            //class burdan ıd yi alıp personel sınıfında tanımlı ıd si ile eşleşip foreign key oluyor

        }


        [Table("Bolum")]
        public class Bolum : Tanimlar
        {
            public Bolum()
            {
                this.Personel = new HashSet<Personel>();
            }
        }


        [Table("Unvan")]
        public class Unvan : Tanimlar
        {
            public Unvan()
            {
                this.Personel = new HashSet<Personel>();
            }
        }


        [Table("Egitim")]
        public class Egitim : Tanimlar
        {
            public Egitim()
            {
                this.Personel = new HashSet<Personel>();
            }

        }


        [Table("Ilce")]
        public class Ilce : Tanimlar
        {
            public Ilce()
            {
                this.Personel = new HashSet<Personel>();
            }
            public int IlId { get; set; }
            [ForeignKey("IlId")]
            public Il Il { get; set; }
        }


        [Table("Il")]
        public class Il
        {
            public Il()
            {
                this.Ilce = new HashSet<Ilce>();
            }
            public int IlId { get; set; }
            public string IlAd { get; set; }
            public virtual ICollection<Ilce> Ilce { get; set; }
        }
    }
}
