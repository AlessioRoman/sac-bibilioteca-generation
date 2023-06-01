using biblioteca_mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace biblioteca_mvc.Database
{
    public class BookContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<BookModel> Books { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BookDb;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
