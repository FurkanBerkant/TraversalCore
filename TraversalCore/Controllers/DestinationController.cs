using Business.Concrete;
using DataAccess.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var values =destinationManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetail(Destination p) 
        {
            return View();
        }
    }
}
