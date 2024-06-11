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
        // User is the table and Teacher methods to control their actions

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
