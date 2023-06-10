using System.Collections.Generic;

namespace Bibliotheque.Entity
{
    public class Statut
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Offre> Offres { get; set; }
        public override string ToString()
        {
            return Libelle;
        }
    }
    
}