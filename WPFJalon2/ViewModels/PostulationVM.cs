using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFJalon2.ViewModels
{
    public class PostulationVM
    {
        public int OffreId { get; set; }
        public int EmployeId { get; set; }
        public EmployeVM Employe { get; set; }
        public DateTime Date { get; set; }
        public int Statut { get; set; }
    }
}
