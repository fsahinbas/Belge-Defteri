using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BelgeDefteri.Data.Entity
{
    public class Kurs : BaseEntity
    {
        public string BelgeAdi { get; set; }
        public int DersSaati { get; set; }
        public int MaxDevamsizlikSayisi { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        /// <summary>
        /// grop tablosundan Parentı Kurs olan
        /// item Id gelecek
        /// </summary>
        public string KursName { get; set; }

        public virtual ICollection<Kursiyer> Kursiyer { get; set; }
        public virtual ICollection<Devamsizlik> Devamsizlik { get; set; }
        public virtual ICollection<Belge> Belgeler { get; set; }
        public virtual ICollection<ApplicationUser> Egitmen { get; set; }

        //TODO gruplar olacak unvan, kurs ve belge türleri

    }
}
