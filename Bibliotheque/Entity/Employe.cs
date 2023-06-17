using System;
using System.Collections.Generic;

namespace Bibliotheque.Entity
{
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom {get; set; }
        public DateTime DateNaissance { get; set; }
        public int Anciennete { get; set; }
        public string Biographie { get; set; }
        
        public HashSet<Formation> Formations { get; set; }
        public HashSet<Experience> Experiences { get; set; }
        public HashSet<Postulation> Postulations { get; set; }
    }
}