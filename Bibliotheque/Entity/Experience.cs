using System;

namespace Bibliotheque.Entity
{
    public class Experience
    {
        public int Id { get; set; }
        public Employe Employe { get; set; }
        public int EmployeId { get; set; }
        public string Intitule { get; set; }
        public DateTime Date { get; set; }
    }
}