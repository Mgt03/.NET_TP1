using System.Linq;
using System;
using Bibliotheque;
using System.Collections;

namespace dotNET.MURAT.GRANET
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new Context();
                /*var employe = new Bibliotheque.Entity.Employe();
                employe.Nom = "employe";
                employe.Prenom = "prenom";
                employe.DateNaissance = DateTime.Now;
                employe.Anciennete = 2;
                employe.Biographie = "bio";
                context.Employes.Add(employe);*/
                var offre = new Bibliotheque.Entity.Offre();
                offre.Intitule = "Intitulé 1";
                offre.Description = "Description 1";
                offre.Date = DateTime.Now;
                offre.Salaire = 15000;
                offre.Responsable = "Responsable 1";
                var status = new Bibliotheque.Entity.Statut();
                offre.StatutId = status.Id;
                status.Libelle = "Libelle 1";
                offre.Statut = status;
                context.Offres.Add(offre);
                context.Offres.Add(offre);
                context.Offres.Add(offre);
                context.Offres.Add(offre);
                context.SaveChanges();
                var list = context.Offres.ToList();
                Console.WriteLine(list.Count());
                list.ForEach(e =>
                {
                    Console.WriteLine(e.Intitule);
                });
                Console.WriteLine("Appuyez sur une touche pour quitter...");
                Console.ReadKey();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}