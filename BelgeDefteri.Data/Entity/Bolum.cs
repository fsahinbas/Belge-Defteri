using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelgeDefteri.Data.Entity
{
    public class Bolum : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Sinif> Siniflar { get; set; }
    }
}
