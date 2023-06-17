using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFJalon2.ViewModels;

namespace WPFJalon2.Mapper
{
    public class StatutMapper
    {
        public static StatutVM ToViewModel(Statut statut)
        {
            return new StatutVM
            {
                Id = statut.Id,
                Libelle = statut.Libelle
            };
        }

        public static Statut ToModel(StatutVM statutViewModel)
        {
            return new Statut
            {
                Id = statutViewModel.Id,
                Libelle = statutViewModel.Libelle
            };
        }
    }
}
