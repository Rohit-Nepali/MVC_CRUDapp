using CRUDapplication.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CRUDapplication.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
            
        }

        //DB Context connects the sqlServer to this application
        public DbSet<User> Teachers { get; set; }
        public DbSet<User> Students { get; set; }
    }
}
