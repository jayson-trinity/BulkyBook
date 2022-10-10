using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<RegistrationModel> Registrations { get; set; }
    }
}
