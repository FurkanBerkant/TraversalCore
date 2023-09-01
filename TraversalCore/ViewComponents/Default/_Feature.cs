using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeauterManager feauterManager = new FeauterManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
           // var values=feauterManager.TGetAll();
         //  ViewBag.image1=feauterManager.get
            return View();
        }
    }
}