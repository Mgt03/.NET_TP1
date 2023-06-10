using System.Linq;
using System.Web.Mvc;
using BusinessLogicLayer;
using BusinessLogicLayer.Queries;

namespace ASPjalon3.Controllers
{
    public class EmployeController : Controller
    {
        private readonly Manager _manager;

        public EmployeController()
        {
            _manager = Manager.Instance();
        }

        public ActionResult Index()
        {
            var employes = _manager.GetAllEmploye();
            return View(employes);
        }

        public ActionResult Details(int id)
        {
            var employe = _manager.GetByIDEmploye(id);
            if (employe == null)
            {
                return HttpNotFound("Employé non trouvé");
            }
            return View(employe);
        }

        public ActionResult Search(string searchTerm)
        {
            var employes = _manager.SearchEmploye(searchTerm);
            return View("Index", employes);
        }
    }
}