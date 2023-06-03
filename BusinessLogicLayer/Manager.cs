using Bibliotheque;
using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BusinessLogicLayer
    {
        private Context context;
        private static BusinessLogicLayer businessLogicLayer;

        public BusinessLogicLayer()
        {
            context = new Context();
        }
        public static BusinessLogicLayer Instance()
        {
            if(businessLogicLayer == null)
            {
                businessLogicLayer = new BusinessLogicLayer();
            }
            return businessLogicLayer;
        }
        public List<Employe> GetAllEmploye()
        {
            EmployeQuery eq = new EmployeQuery(context);
            return eq.GetAll().ToList();
        }
    }
}
