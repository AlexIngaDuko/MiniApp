using Microsoft.EntityFrameworkCore;
using MiniApp.Models;

namespace MiniApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Epicrisis> Epicrisis { get; set; }
        public DbSet<ExamenAuxiliar> ExamenesAuxiliares { get; set; }
        public DbSet<ProcedimientoTerapeuticoEpicrisis> ProcedimientosTerapeuticosEpicrisis { get; set; }
        public DbSet<InformeAlta> InformesAlta { get; set; }
        public DbSet<Contrarreferencia> Contrarreferencias { get; set; }
    }
}