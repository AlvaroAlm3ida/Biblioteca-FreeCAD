using Microsoft.AspNetCore.Mvc;

namespace BibliotecaFreeCAD.Controllers
{
    public class PecaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
