using System;
using System.Linq;
using System.Web.Mvc;
using Bibliotheque.Entity;
using BusinessLogicLayer.Queries;

namespace ASPjalon3.Controllers
{
    public class PostulationController: Controller
    {
        private readonly OffreQuery _offreQuery;
        private readonly EmployeQuery _employeQuery;
        
        public PostulationController(
            OffreQuery offreQuery,
            EmployeQuery employeQuery    
        )
        {
            _offreQuery = offreQuery;
            _employeQuery = employeQuery;
        }

        public ActionResult Postuler(int id)
        {
            
            
            // Récupérer l'offre à partir de l'ID
            var offre = _offreQuery.GetAll().FirstOrDefault(o => o.Id == id);

            // Vérifier si l'offre existe
            if (offre == null)
            {
                return HttpNotFound("Offre non trouvée");
            }

            var employeConnecte = _employeQuery.GetAll().FirstOrDefault(e => e.Id == 1);

            // Créer une nouvelle postulation
            if (employeConnecte != null)
            {
                var postulation = new Postulation
                {
                    OffreId = offre.Id,
                    EmployeId = employeConnecte.Id,
                    Date = DateTime.Now,
                    Statut = 1
                };

                offre.Postulations.Add(postulation);
                return RedirectToAction("Details", "Offre", new { id = offre.Id });

            }
            else
            {
                return HttpNotFound("Employé non trouvé");
            }
        }
        
        public ActionResult Index()
        {
            var employeConnecte = _employeQuery.GetAll().FirstOrDefault(e => e.Id == 1);
            if (employeConnecte != null)
            {
                var postulations = employeConnecte.Postulations;
                return View(postulations);
            }
            else
            {
                return HttpNotFound("Employé non trouvé");
            }
        }

    }
}