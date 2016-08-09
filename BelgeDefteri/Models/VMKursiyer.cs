using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BelgeDefteri.Models
{
    public class VMKursiyer
    {
        public string id { get; set; }
        public string tcKimlik { get; set; }
        public int okulNo { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string sinifId { get; set; }
        public string babaAdi { get; set; }
        public string anaAdi { get; set; }
        public string dogumYeri { get; set; }
        public DateTime dogumTarihi { get; set; }

    }
}