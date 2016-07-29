using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelgeDefteri.Model
{
    public class VMKurs
    {
        public string id { get; set; }
        public string name { get; set; }
        public string belgeAdi { get; set; }
        public int dersSaari { get; set; }
        public int maxDevamsizlikSayisi { get; set; }
        public DateTime baslamaTarihi { get; set; }
        public DateTime bitisTarihi { get; set; }

    
    }
}
