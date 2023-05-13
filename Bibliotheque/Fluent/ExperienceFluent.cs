using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Bibliotheque.Entity;

namespace Bibliotheque.Fluent
{
    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("APP_EXPERIENCE");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("EXP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Intitule).HasColumnName("EXP_INTITULE").IsRequired().HasMaxLength(50);
            Property(c => c.Date).HasColumnName("EXP_DATE").IsRequired();
            Property(c => c.EmployeId).HasColumnName("EMP_ID").IsRequired();

            HasRequired(c => c.Employe).WithMany(c => c.Experiences).HasForeignKey(c => c.EmployeId);
        }
    }
}