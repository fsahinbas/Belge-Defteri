using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelgeDefteri.Data.Entity
{

    public class Kursiyer : BaseEntity
    {
        
        [Required]
        public string TcKimlik { get; set; }
        public int OkulNo { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        [ForeignKey("Sinif")]
        public string SinifId { get; set; }
        public Sinif Sinif { get; set; }

        public virtual ICollection<Kurs> Kurslar { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public virtual ICollection<Belge> Belgeler { get; set; }

    }
}
