using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Bibliotheque.Entity;

namespace Bibliotheque.Fluent
{
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_STATUT");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(50);
        }
    }
}