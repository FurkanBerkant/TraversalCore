using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager testimonialManager=new TestimonialManager(new EfTestimonialDal());  
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetAll();
            return View(values);
        }
    }
}
