using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Bibliotheque.Entity;

namespace Bibliotheque.Fluent
{
    public class OffreFluent : EntityTypeConfiguration<Offre>
    {
        public OffreFluent()
        {
            ToTable("APP_OFFRE");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("OFF_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Intitule).HasColumnName("OFF_INTITULE").IsRequired().HasMaxLength(50);
            Property(c => c.Description).HasColumnName("OFF_DESCRIPTION").IsRequired().HasMaxLength(500);
            Property(c => c.Responsable).HasColumnName("OFF_RESPONSABLE").IsRequired().HasMaxLength(50);
            Property(c => c.Date).HasColumnName("OFF_DATE").IsRequired();
            Property(c => c.Salaire).HasColumnName("OFF_SALAIRE").IsRequired();
            HasRequired(c => c.Statut).WithMany().HasForeignKey(c => c.StatutId);
            
        }
    }
}