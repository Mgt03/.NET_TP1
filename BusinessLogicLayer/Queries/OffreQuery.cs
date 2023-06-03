using Bibliotheque;
using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Queries
{
    class OffreQuery
    {
        private readonly Context context;

        public OffreQuery(Context context)
        {
            this.context = context;
        }

        public IQueryable<Offre> GetAll()
        {
            return context.Offres;
        }

        public IQueryable<Offre> GetByID(int id)
        {
            return context.Offres.Where(o => o.Id == id);
        }
    }
}
