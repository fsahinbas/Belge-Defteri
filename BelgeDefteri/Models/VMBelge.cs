using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BelgeDefteri.Models
{
    public class VMBelge
    {
        public string id { get; set; }
        public int belgeNo { get; set; }
        public string belgeAdi { get; set; }
        public string belgeAciklama { get; set; }
        public DateTime belgeTarih { get; set; }
        public string egitmen { get; set; }
        public string idareci { get; set; }
        public DateTime basimTarihi { get; set; }
        public bool basildiMi { get; set; }
        public string kursiyerId { get; set; }
        public string kursId { get; set; }

    }
}