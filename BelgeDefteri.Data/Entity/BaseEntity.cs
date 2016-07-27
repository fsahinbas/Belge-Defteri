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
        public DateTime CreatDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
