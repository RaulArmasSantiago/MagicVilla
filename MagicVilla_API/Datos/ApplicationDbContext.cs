using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Xalapa",
                    Detalle = "Ciudad de las flores",
                    ImagenUrl = "",
                    Ocupantes = 1000,
                    Tarifa = 200,
                    Amenidad = "Lagos",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                new Villa(){
                Id = 2,
                    Nombre = "Xico",
                    Detalle = "Ciudad del pan",
                    ImagenUrl = "",
                    Ocupantes = 1000,
                    Tarifa = 200,
                    Amenidad = "Lagos",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
                );
        }

    }
}
