using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.WebApp.Models;

namespace RealEstateWebApi.WebApp.ViewComponents;

public class _OwnedPropertyDetailViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(OuterPropertyListing outerPropertyListing,IEnumerable<PropertyListingPhoto> propertyListingPhotos){
        return View(Tuple.Create(outerPropertyListing,propertyListingPhotos));
    }

}
