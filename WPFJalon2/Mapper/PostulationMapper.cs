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
    public class PostulationMapper
    {
        public static PostulationVM ToViewModel(Postulation postulation)
        {
            return new PostulationVM
            {
                OffreId = postulation.OffreId,
                EmployeId = postulation.EmployeId,
                Employe = EmployeMapper.ToViewModel(postulation.Employe),
                Date = postulation.Date,
                Statut = postulation.Statut
            };
        }

        public static ObservableCollection<PostulationVM> ToViewModels(HashSet<Postulation> postulations)
        {
            return new ObservableCollection<PostulationVM>(postulations.Select(ToViewModel).ToList());
        }

        public static Postulation ToModel(PostulationVM postulationViewModel)
        {
            return new Postulation
            {
                OffreId = postulationViewModel.OffreId,
                EmployeId = postulationViewModel.EmployeId,
                Employe = EmployeMapper.ToModel(postulationViewModel.Employe),
                Date = postulationViewModel.Date,
                Statut = postulationViewModel.Statut
            };
        }

        public static HashSet<Postulation> ToModels(ObservableCollection<PostulationVM> postulationViewModels)
        {
            return new HashSet<Postulation>(postulationViewModels.Select(ToModel).ToList());
        }
    }
}
