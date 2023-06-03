using System.Linq;
using System;
using Bibliotheque;

namespace dotNET.MURAT.GRANET
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new Context();
                var employe = new Bibliotheque.Entity.Employe();
                employe.Nom = "employe";
                employe.Prenom = "prenom";
                employe.DateNaissance = DateTime.Now;
                employe.Anciennete = 2;
                employe.Biographie = "bio";
                context.Employes.Add(employe);
                context.SaveChanges();
                var list = context.Employes.ToList();
                Console.WriteLine(list.Count());
                list.ForEach(e =>
                {
                    Console.WriteLine(e.Nom);
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