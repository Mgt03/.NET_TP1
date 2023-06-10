using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bibliotheque.Entity;
using BusinessLogicLayer.Queries;

namespace ASPjalon3.Controllers
{
    public class OffreController : Controller
    {
        private readonly OffreQuery _offreQuery;

        public OffreController(
            OffreQuery offreQuery
        )
        {
            _offreQuery = offreQuery;
        }

        public ActionResult Index()
        {
            var offres = _offreQuery.GetAll().ToList();
            return View(offres);
        }

        public ActionResult Details(int id)
        {
            var offre = _offreQuery.GetByID(id).FirstOrDefault();
            if (offre == null)
            {
                return HttpNotFound("Offre non trouvée");
            }
            return View(offre);
        }

        public ActionResult Search(string searchTerm)
        {
            var offres = _offreQuery.Search(searchTerm).ToList();
            return View("Index",offres);
        }
    }
}