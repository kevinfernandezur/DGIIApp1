using Microsoft.EntityFrameworkCore;
using DGIIApp.Models;

namespace DGIIApp.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Contribuyente> Contribuyentes { get; set; }
        public DbSet<ComprobanteFiscal> Comprobantes { get; set; }


    }

}
