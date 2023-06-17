using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFJalon2.ViewModels
{
    public class OffreVM
    {
        public int Id { get; set; }
        public string Intitule { get; set; }
        public DateTime Date { get; set; }
        public int Salaire { get; set; }
        public string Description { get; set; }
        public string Responsable { get; set; }
        public StatutVM Statut { get; set; }
        public ObservableCollection<PostulationVM> Postulations { get; set; }
    }
}
