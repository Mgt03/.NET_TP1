using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.Entity;

namespace Bibliotheque
{
    public class Context : DbContext
    {
        protected Context() : base("name=app")
        {
        }
        
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Offre> Offres { get; set; }
        public DbSet<Postulation> Postulations { get; set; }
        public DbSet<Statut> Statuts { get; set; }
    }
}
