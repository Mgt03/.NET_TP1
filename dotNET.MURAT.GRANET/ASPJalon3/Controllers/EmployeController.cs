using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bibliotheque.Entity;
using BusinessLogicLayer.Queries;

namespace ASPjalon3.Controllers
{
    public class EmployeController : Controller
    {
        private readonly EmployeQuery _employeQuery;

        public EmployeController(
            EmployeQuery employeQuery
        )
        {
            this._employeQuery = employeQuery;
        }

        public ActionResult Index()
        {
            List<Employe> employes = _employeQuery.GetAll().ToList();
            // Récupérer tous les employés
            return View(employes);
        }

        public ActionResult Details(int id)
        {
            // Récupérer l'employé avec l'ID spécifié
            IQueryable<Employe> employes = _employeQuery.GetAll();
            var employe = employes.FirstOrDefault(e => e.Id == id);
            if (employe == null)
            {
                return HttpNotFound("Employé non trouvé");
            }
            return View(employe);
        }

        public ActionResult Search(string searchTerm)
        {
            IQueryable<Employe> employes = _employeQuery.GetAll();
            // Rechercher les employés qui correspondent au terme de recherche
            var filteredEmployes = employes.Where(e => e.Nom.Contains(searchTerm) || e.Prenom.Contains(searchTerm)).ToList();
            return View("Index", filteredEmployes);
        }
    }
}