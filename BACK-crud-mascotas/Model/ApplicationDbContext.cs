using Microsoft.EntityFrameworkCore;

namespace BACK_crud_mascotas.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Mascota> Mascota { get; set; }
    }
}
