using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFJalon2.ViewModels
{
    public class EmployeVM
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Anciennete { get; set; }
        public string Biographie { get; set; }

        public ObservableCollection<FormationVM> Formations { get; set; }
        public ObservableCollection<ExperienceVM> Experiences { get; set; }
        public ObservableCollection<PostulationVM> Postulations { get; set; }

    }
}
