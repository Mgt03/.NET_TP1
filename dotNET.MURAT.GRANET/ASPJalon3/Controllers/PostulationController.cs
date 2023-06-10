using System;
using System.Linq;
using System.Web.Mvc;
using Bibliotheque.Entity;
using BusinessLogicLayer.Commands;
using BusinessLogicLayer.Queries;

namespace ASPjalon3.Controllers
{
    public class PostulationController: Controller
    {
        private readonly OffreQuery _offreQuery;
        private readonly EmployeQuery _employeQuery;
        private readonly PostulationCommand _postulationCommand;
        
        public PostulationController(
            OffreQuery offreQuery,
            EmployeQuery employeQuery,  
            PostulationCommand postulationCommand
        )
        {
            _offreQuery = offreQuery;
            _employeQuery = employeQuery;
            _postulationCommand = postulationCommand;
        }

        public ActionResult Postuler(int id)
        {
            var offre = _offreQuery.GetByID(id).FirstOrDefault();
            if (offre == null)
            {
                return HttpNotFound("Offre non trouvée");
            }
            var employeConnecte = _employeQuery.GetByID(1).FirstOrDefault();

            if (employeConnecte != null)
            {
                var postulation = new Postulation
                {
                    OffreId = offre.Id,
                    EmployeId = employeConnecte.Id,
                    Date = DateTime.Now,
                    Statut = 1
                };

                _postulationCommand.Ajouter(postulation);
                return RedirectToAction("Details", "Offre", new { id = offre.Id });

            }
            else
            {
                return HttpNotFound("Employé non trouvé");
            }
        }
        
        public ActionResult Index()
        {
            var employeConnecte = _employeQuery.GetByID(1).FirstOrDefault();
            if (employeConnecte == null) return HttpNotFound("Employé non trouvé");
            var postulations = employeConnecte.Postulations;
            return View(postulations);
        }

    }
}