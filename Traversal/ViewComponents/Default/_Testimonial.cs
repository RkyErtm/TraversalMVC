using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonalManager testimonalManager = new TestimonalManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonalManager.TGetList();
            return View(values);
        }
    }
}
