using System;

namespace Bibliotheque.Entity
{
    public class Postulation
    {
        public Offre Offre { get; set; }
        public int OffreId { get; set; }

        public Employe Employe { get; set; }
        public int EmployeId { get; set; }
        public DateTime Date { get; set; }
        public int Statut { get; set; }
    }
}