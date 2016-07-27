using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
namespace BelgeDefteri.Data.Entity
{

    public class ApplicationUser : IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Belge> Belgeler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Devamsizlik> Devamsizliklar { get; set; }
        public DbSet<Grup> Gruplar { get; set; }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<Kursiyer> Kursiyerler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }


       
    }
   
}