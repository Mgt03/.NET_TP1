using Bibliotheque;
using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Queries
{
    public class StatutQuery
    {
        private Context context;

        public StatutQuery(Context context)
        {
            this.context = context;
        }

        public IQueryable<Statut> GetAll()
        {
            return context.Statuts;
        }
    }
}
