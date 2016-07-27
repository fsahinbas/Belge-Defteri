using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BelgeDefteri.Data.Entity
{
    public class Grup :BaseEntity
    {
        
        public string ParetnId { get; set; }
        public string Adi { get; set; }
       
    }
}
