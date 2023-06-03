using Bibliotheque;
using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Queries
{
    class EmployeQuery
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

        public IQueryable<Employe> GetByID(int id)
        {
            return context.Employes.Where(e => e.Id == id);
        }
    }
}
