using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bibliotheque.Entity;
using BusinessLogicLayer;
using BusinessLogicLayer.Queries;

namespace ASPjalon3.Controllers
{
    public class OffreController : Controller
    {
        private readonly Manager _manager;

        public OffreController()
        {
            _manager = Manager.Instance();
        }

        public ActionResult Index()
        {
            var offres = _manager.GetAllOffres();
            return View(offres);
        }

        public ActionResult Details(int id)
        {
            var offre = _manager.GetByIDOffre(id);
            if (offre == null)
            {
                return HttpNotFound("Offre non trouvée");
            }
            return View(offre);
        }

        public ActionResult Search(string searchTerm)
        {
            var offres = _manager.SearchOffre(searchTerm);
            return View("Index",offres);
        }
    }
}