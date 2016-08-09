using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BelgeDefteri.Data.Entity
{
    public class Belge : BaseEntity
    {
        public int BelgeNo { get; set; }
        public string BelgeAdi { get; set; }
        public string BelgeAciklama { get; set; }
        public DateTime BelgeTarih { get; set; }
        public string Egitmen { get; set; }
        public string Idareci { get; set; }
        public DateTime BasimTarihi { get; set; }
        public bool BasildiMi { get; set; }

        [ForeignKey("Kursiyer")]
        public string KursiyerId { get; set; }
        public Kursiyer Kursiyer { get; set; }
     
        [ForeignKey("Kurs")]
        public string KursId{ get; set; }
        public Kurs Kurs { get; set; }

    }
}
