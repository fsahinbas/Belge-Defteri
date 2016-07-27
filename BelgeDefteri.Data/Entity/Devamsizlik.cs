using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BelgeDefteri.Data.Entity
{
    public class Devamsizlik
    {
        [Key]
        public string Id { get; set; }
        public DateTime Tarih { get; set; }
        public int DevamsizlikMiktari { get; set; }
        [ForeignKey("Kurs")]
        public string KursId { get; set; }
        [ForeignKey("Kursiyer")]
        public string KursiyerId { get; set; }

        public Kurs Kurs { get; set; }
        public Kursiyer Kursiyer { get; set; }
    }
}
