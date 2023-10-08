using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
            var values=destinationManager.TGetList();
            return View(values);
        }
    }
}
