using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BelgeDefteri.Data.Entity
{
    public class Sinif : BaseEntity
    {
        public int SinifNo { get; set; }
        public string OkulTuru { get; set; }
        public string Sube { get; set; }

        [ForeignKey("Bolum")]
        public string BolumId { get; set; }
        public Bolum Bolum { get; set; }

        public virtual ICollection<Kursiyer> Kursiyerler { get; set; }
    }
}
