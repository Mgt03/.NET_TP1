using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFJalon2.ViewModels;
using static WPFJalon2.ViewModels.FormationVM;

namespace WPFJalon2.Mapper
{
    public class FormationMapper
    {
        public static FormationVM ToViewModel(Formation formation)
        {
            return new FormationVM
            {
                Id = formation.Id,
                EmployeId = formation.EmployeId,
                Intitule = formation.Intitule,
                Date = formation.Date
            };
        }

        public static ObservableCollection<FormationVM> ToViewModels(HashSet<Formation> formations)
        {
            return new ObservableCollection<FormationVM>(formations.Select(ToViewModel).ToList());
        }

        public static Formation ToModel(FormationVM formationViewModel)
        {
            return new Formation
            {
                Id = formationViewModel.Id,
                EmployeId = formationViewModel.EmployeId,
                Intitule = formationViewModel.Intitule,
                Date = formationViewModel.Date
            };
        }

        public static HashSet<Formation> ToModels(ObservableCollection<FormationVM> formationViewModels)
        {
            return new HashSet<Formation>(formationViewModels.Select(ToModel).ToList());
        }
    }
}
