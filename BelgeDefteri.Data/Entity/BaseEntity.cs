using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelgeDefteri.Data.Entity
{
    /// <summary>
    /// Temel entity sınıfı
    /// tüm entitilerde gerekli olan alanlar 
    /// mevcut
    /// </summary>
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string CreateUser { get; set; }
       [Column(TypeName = "datetime2")]
        public DateTime CreatDate { get; set; }
        public string UpdateUser { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }
    }
}
