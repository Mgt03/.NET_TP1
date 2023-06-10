using System.Collections.Generic;
using System.Linq;
using Bibliotheque;
using Bibliotheque.Entity;
using BusinessLogicLayer.Queries;

namespace BusinessLogicLayer
{
    public class Manager
    {
        private Context context;
        private static Manager businessLogicLayer;

        public Manager()
        {
            context = new Context();
        }
        public static Manager Instance()
        {
            if(businessLogicLayer == null)
            {
                businessLogicLayer = new Manager();
            }
            return businessLogicLayer;
        }
        public List<Employe> GetAllEmploye()
        {
            EmployeQuery eq = new EmployeQuery(context);
            return eq.GetAll().ToList();
        }

        public List<Offre> GetAllOffres()
        {
            OffreQuery oq = new OffreQuery(context);
            return oq.GetAll().ToList();

        }

        public List<Statut> GetAllStatuts()
        {
            StatutQuery sq = new StatutQuery(context);
            return sq.GetAll().ToList();
        }
    }
}
