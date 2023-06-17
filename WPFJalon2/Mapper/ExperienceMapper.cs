using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFJalon2.ViewModels;

namespace WPFJalon2.Mapper
{
    public class ExperienceMapper
    {
        public static ExperienceVM ToViewModel(Experience experience)
        {
            return new ExperienceVM
            {
                Id = experience.Id,
                EmployeId = experience.EmployeId,
                Intitule = experience.Intitule,
                Date = experience.Date
            };
        }

        public static ObservableCollection<ExperienceVM> ToViewModels(HashSet<Experience> experiences)
        {
            return new ObservableCollection<ExperienceVM>(experiences.Select(ToViewModel).ToList());
        }

        public static Experience ToModel(ExperienceVM experienceViewModel)
        {
            return new Experience
            {
                Id = experienceViewModel.Id,
                EmployeId = experienceViewModel.EmployeId,
                Intitule = experienceViewModel.Intitule,
                Date = experienceViewModel.Date
            };
        }

        public static HashSet<Experience> ToModels(ObservableCollection<ExperienceVM> experienceViewModels)
        {
            return new HashSet<Experience>(experienceViewModels.Select(ToModel).ToList());
        }
    }
}
