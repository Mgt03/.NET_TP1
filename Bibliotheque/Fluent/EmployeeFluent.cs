using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Bibliotheque.Entity;

namespace Bibliotheque.Fluent
{
    public class EmployeeFluent : EntityTypeConfiguration<Employe>
    {
        public EmployeeFluent()
        {
            ToTable("APP_EMPLOYE");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("EMP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nom).HasColumnName("EMP_NOM").IsRequired().HasMaxLength(50);
            Property(c => c.Prenom).HasColumnName("EMP_PRENOM").IsRequired().HasMaxLength(50);
            Property(c => c.DateNaissance).HasColumnName("EMP_DATENAISSANCE").IsRequired();
            Property(c => c.Anciennete).HasColumnName("EMP_ANCIENNETE").IsRequired();
            Property(c => c.Biographie).HasColumnName("EMP_BIOGRAPHIE").IsRequired().HasMaxLength(500);
            HasMany(c => c.Formations).WithRequired(c => c.Employe).HasForeignKey(c => c.EmployeId);
            HasMany(c => c.Experiences).WithRequired(c => c.Employe).HasForeignKey(c => c.EmployeId);
            HasMany(c => c.Postulations).WithRequired(c => c.Employe).HasForeignKey(c => c.EmployeId);
        }
    }
}