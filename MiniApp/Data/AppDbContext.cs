using Microsoft.EntityFrameworkCore;
using MiniApp.Models;

namespace MiniApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }
        
        public DbSet<User> Users { get; set; }

       
    }
}
