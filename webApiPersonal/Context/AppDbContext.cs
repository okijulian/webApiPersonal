using Microsoft.EntityFrameworkCore;
using webApiPersonal.Models;

namespace webApiPersonal.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) 
        {
            
        }
        public DbSet<Persona>Personas { get; set; }

    }
}
