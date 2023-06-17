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
    public class OffreMapper
    {
        public static OffreVM ToViewModel(Offre offre)
        {
            return new OffreVM
            {
                Id = offre.Id,
                Intitule = offre.Intitule,
                Date = offre.Date,
                Salaire = offre.Salaire,
                Description = offre.Description,
                Responsable = offre.Responsable,
                Statut = StatutMapper.ToViewModel(offre.Statut),
                Postulations = new ObservableCollection<PostulationVM>(PostulationMapper.ToViewModels(offre.Postulations))
            };
        }

        public static Offre ToModel(OffreVM offreViewModel)
        {
            return new Offre
            {
                Id = offreViewModel.Id,
                Intitule = offreViewModel.Intitule,
                Date = offreViewModel.Date,
                Salaire = offreViewModel.Salaire,
                Description = offreViewModel.Description,
                Responsable = offreViewModel.Responsable,
                Statut = StatutMapper.ToModel(offreViewModel.Statut),
                Postulations = new HashSet<Postulation>(PostulationMapper.ToModels(offreViewModel.Postulations))
            };
        }
    }
}
