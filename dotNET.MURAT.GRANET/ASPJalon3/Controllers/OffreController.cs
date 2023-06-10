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
            this._offreQuery = offreQuery;
        }

        public ActionResult Index()
        {
            // Récupérer toutes les offres
            IQueryable<Offre> offres = _offreQuery.GetAll();
            return View(offres.ToList());
        }

        public ActionResult Details(int id)
        {
            // Récupérer l'offre avec l'ID spécifié
            IQueryable<Offre> offres = _offreQuery.GetAll();
            var offre = offres.FirstOrDefault(o => o.Id == id);
            if (offre == null)
            {
                return HttpNotFound("Offre non trouvée");
            }
            return View(offre);
        }

        public ActionResult Search(string searchTerm)
        {
            // Rechercher les offres qui correspondent au terme de recherche
            IQueryable<Offre> offres = _offreQuery.GetAll();
            var filteredOffres = offres.Where(o => o.Intitule.Contains(searchTerm)).ToList();
            return View("Index",filteredOffres);
        }
    }
}