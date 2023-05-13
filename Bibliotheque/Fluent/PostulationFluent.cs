using System.Data.Entity.ModelConfiguration;
using Bibliotheque.Entity;

namespace Bibliotheque.Fluent
{
    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("APP_POSTULATION");
            HasKey(c => new { c.OffreId, c.EmployeId });
            Property(c => c.OffreId).HasColumnName("OFF_ID").IsRequired();
            Property(c => c.EmployeId).HasColumnName("EMP_ID").IsRequired();
            Property(c => c.Date).HasColumnName("POS_DATE").IsRequired();
            Property(c => c.Statut).HasColumnName("POS_STATUT").IsRequired();
        }
    }
}