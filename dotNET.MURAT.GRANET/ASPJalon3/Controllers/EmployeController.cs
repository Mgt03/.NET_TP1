using System.Linq;
using System.Web.Mvc;
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
            _employeQuery = employeQuery;
        }

        public ActionResult Index()
        {
            var employes = _employeQuery.GetAll().ToList();
            // Récupérer tous les employés
            return View(employes);
        }

        public ActionResult Details(int id)
        {
            var employe = _employeQuery.GetByID(id).FirstOrDefault();
            if (employe == null)
            {
                return HttpNotFound("Employé non trouvé");
            }
            return View(employe);
        }

        public ActionResult Search(string searchTerm)
        {
            var employes = _employeQuery.Search(searchTerm).ToList();
            return View("Index", employes);
        }
    }
}