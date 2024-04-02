using EfCore6Fundaments.Domian;
using Microsoft.EntityFrameworkCore;

namespace EfCore6Fundaments.Data
{
    public class PubContext : DbContext
    {
        // Aqui las tablas
        public DbSet<Author > Authors { get; set; }
        public DbSet<Book> Books { get; set; }


        //Iniciacion de la conexion 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PubDbContext;"

                );
        }

    }
}
