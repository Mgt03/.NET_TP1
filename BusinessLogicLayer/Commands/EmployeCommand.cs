using Bibliotheque;
using Bibliotheque.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Commands
{
    class EmployeCommand
    {
        private readonly Context context;

        public EmployeCommand(Context context)
        {
            this.context = context;
        }

        public int Ajouter(Employe employe)
        {
            context.Employes.Add(employe);
            return context.SaveChanges();
        }

        public int Modifier(Employe employe)
        {
            Employe emp = context.Employes.Where(e => e.Id == employe.Id).FirstOrDefault();
            if(emp != null)
            {
                emp.Nom = employe.Nom;
                emp.Prenom = employe.Prenom;
                emp.Experiences = employe.Experiences;
                emp.DateNaissance = employe.DateNaissance;
                emp.Biographie = employe.Biographie;
                emp.Anciennete = employe.Anciennete;
            }
            return context.SaveChanges();
        }

        public int Supprimer(Employe employe)
        {
            Employe emp = context.Employes.Where(e => e.Id == employe.Id).FirstOrDefault();
            if(emp != null)
            {
                context.Employes.Remove(emp);
            }
            return context.SaveChanges();
        }
    }
}
