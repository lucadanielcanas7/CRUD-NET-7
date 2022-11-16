using CRUDNet7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNet7MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Models
        public DbSet<Contact> Contact { get; set; }
    }
}
