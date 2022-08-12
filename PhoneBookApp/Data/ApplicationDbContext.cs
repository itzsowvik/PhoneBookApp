using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Models;

namespace PhoneBookApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
    }
}
