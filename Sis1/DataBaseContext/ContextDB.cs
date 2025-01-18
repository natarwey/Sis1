using Microsoft.EntityFrameworkCore;
using Sis1.Model;

namespace Sis1.DataBaseContext
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Logins> Logins { get; set; }
    }
}
