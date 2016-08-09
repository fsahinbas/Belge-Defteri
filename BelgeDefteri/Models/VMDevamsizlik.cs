using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BelgeDefteri.Models
{
    public class VMDevamsizlik
    {
        public string id { get; set; }
        public DateTime tarih { get; set; }
        public int devamsizlikMiktari { get; set; }
        public string kursId { get; set; }
        public string kursiyerId { get; set; }

    }
}