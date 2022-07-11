using ApiDbLayerTC.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiDbLayerTC
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
        { }
        public ApiDbContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassRoom> Classrooms { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CEIJQT1;Database=TCwebApiDB;Trusted_Connection=True;");
        }



    }
}
