using System;
using System.Collections.Generic;
using System.Linq;
using Bibliotheque;
using Bibliotheque.Entity;
using BusinessLogicLayer.Commands;
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

        public void UpdateOffre(Offre offre)
        {
            OffreCommand oc = new OffreCommand(context);
            oc.Update(offre);
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

        public Employe GetByIDEmploye(int id)
        {
            EmployeQuery eq = new EmployeQuery(context);
            return eq.GetByID(id).FirstOrDefault();
        }

        public List<Employe> SearchEmploye(string searchTerm)
        {
            EmployeQuery eq = new EmployeQuery(context);
            return eq.Search(searchTerm).ToList();
        }

        public Offre GetByIDOffre(int id)
        {
            OffreQuery oq = new OffreQuery(context);
            return oq.GetByID(id).FirstOrDefault();
        }

        public List<Offre> SearchOffre(string searchTerm)
        {
            OffreQuery oq = new OffreQuery(context);
            return oq.Search(searchTerm).ToList();
        }

        public void AjouterPostulation(Postulation postulation)
        {
            PostulationCommand pc = new PostulationCommand(context);
            pc.Ajouter(postulation);
        }

        public void AddOffre(Offre offre)
        {
            OffreCommand oc = new OffreCommand(context);
            oc.Ajouter(offre);
        }

        public void DeleteOffre(int id)
        {
            OffreCommand oc = new OffreCommand(context);
            oc.Delete(id);
        }
    }
}
