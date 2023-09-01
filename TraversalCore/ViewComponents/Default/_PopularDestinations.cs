using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestinationManager destinationManager=new DestinationManager(new EfDestinationDal());
    public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetAll();
            return View(values);
        }
    }
}
