using Bibliotheque;
using Bibliotheque.Entity;
using System.Linq;

namespace BusinessLogicLayer.Queries
{
    public class EmployeQuery
    {
        private readonly Context context;

        public EmployeQuery(Context context)
        {
            this.context = context;
        }

        public IQueryable<Employe> GetAll()
        {
            return context.Employes;
        }
        
        public IQueryable<Employe> Search(string searchTerm)
        {
            return context.Employes.Where(e => e.Nom.Contains(searchTerm) || e.Prenom.Contains(searchTerm));
        }

        public IQueryable<Employe> GetByID(int id)
        {
            return context.Employes.Where(e => e.Id == id);
        }
    }
}