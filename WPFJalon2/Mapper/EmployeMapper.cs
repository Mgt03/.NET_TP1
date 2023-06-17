using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFJalon2.Mapper;

namespace WPFJalon2.ViewModels
{
    public class EmployeMapper
    {
        public static EmployeVM ToViewModel(Employe employe)
        {
            return new EmployeVM
            {
                Id = employe.Id,
                Nom = employe.Nom,
                Prenom = employe.Prenom,
                DateNaissance = employe.DateNaissance,
                Anciennete = employe.Anciennete,
                Biographie = employe.Biographie,
            };
        }

        public static Employe ToModel(EmployeVM employeViewModel)
        {
            return new Employe
            {
                Id = employeViewModel.Id,
                Nom = employeViewModel.Nom,
                Prenom = employeViewModel.Prenom,
                DateNaissance = employeViewModel.DateNaissance,
                Anciennete = employeViewModel.Anciennete,
                Biographie = employeViewModel.Biographie,
            };
        }
    }
}
