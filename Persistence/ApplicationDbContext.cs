using AuSocialApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AuSocialApp.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Value> Values { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }
    }
}