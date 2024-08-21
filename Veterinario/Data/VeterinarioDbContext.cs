using Microsoft.EntityFrameworkCore;
using Veterinario.Models;

namespace Veterinario.Data
{
    public class VeterinarioDbContext : DbContext
    {
        public VeterinarioDbContext(DbContextOptions<VeterinarioDbContext> options) 
            : base(options) { }

        public DbSet<Animal> animales { get; set; }
    }
}
