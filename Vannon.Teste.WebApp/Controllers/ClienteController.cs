using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vannon.Teste.WebApp.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
