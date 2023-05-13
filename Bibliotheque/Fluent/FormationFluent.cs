using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Bibliotheque.Entity;

namespace Bibliotheque.Fluent
{
    public class FormationFluent : EntityTypeConfiguration<Formation>
    {
        public FormationFluent()
        {
            ToTable("APP_FORMATION");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("FOR_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Intitule).HasColumnName("FOR_INTITULE").IsRequired().HasMaxLength(50);
            Property(c => c.Date).HasColumnName("FOR_DATE").IsRequired();
            HasRequired(c => c.Employe).WithMany(c => c.Formations).HasForeignKey(c => c.EmployeId);
        }
    }
}