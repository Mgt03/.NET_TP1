using System.Data.Entity;
using System.Reflection;
using Bibliotheque.Entity;

namespace Bibliotheque
{
    public class Context : DbContext
    {
        public Context() : base("name=app")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Employe> Employes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Offre> Offres { get; set; }
        public DbSet<Postulation> Postulations { get; set; }
        public DbSet<Statut> Statuts { get; set; }
    }
}
