using System;
using System.Linq;
using System.Web.Mvc;
using Bibliotheque.Entity;
using BusinessLogicLayer;
using BusinessLogicLayer.Commands;
using BusinessLogicLayer.Queries;

namespace ASPjalon3.Controllers
{
    public class PostulationController: Controller
    {
        private readonly Manager _manager;
        
        public PostulationController()
        {
            _manager = Manager.Instance();
        }

        public ActionResult Postuler(int id)
        {
            var offre = _manager.GetByIDOffre(id);
            if (offre == null)
            {
                return HttpNotFound("Offre non trouvée");
            }
            var employeConnecte = _manager.GetByIDEmploye(1);

            if (employeConnecte != null)
            {
                var postulation = new Postulation
                {
                    OffreId = offre.Id,
                    EmployeId = employeConnecte.Id,
                    Date = DateTime.Now,
                    Statut = 1
                };

                _manager.AjouterPostulation(postulation);
                return RedirectToAction("Details", "Offre", new { id = offre.Id });

            }
            else
            {
                return HttpNotFound("Employé non trouvé");
            }
        }
        
        public ActionResult Index()
        {
            var employeConnecte = _manager.GetByIDEmploye(1);
            if (employeConnecte == null) return HttpNotFound("Employé non trouvé");
            var postulations = employeConnecte.Postulations;
            return View(postulations);
        }

    }
}