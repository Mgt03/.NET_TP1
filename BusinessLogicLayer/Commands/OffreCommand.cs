using Bibliotheque;
using Bibliotheque.Entity;
using System.Linq;

namespace BusinessLogicLayer
{
    internal class OffreCommand
    {
        private Context context;

        public OffreCommand(Context context)
        {
            this.context = context;
        }

        internal int Update(Offre offre)
        {
            Offre offre1 = context.Offres.Where(e => e.Id == offre.Id).FirstOrDefault();
            if (offre1 != null)
            {
                offre1.Intitule = offre.Intitule;
                offre1.Description = offre.Description;
                offre1.Date = offre.Date;
                offre1.Salaire = offre.Salaire;
                offre1.Responsable = offre.Responsable;
                offre1.Statut = offre.Statut;
            }
            return context.SaveChanges();
        }
    }
}