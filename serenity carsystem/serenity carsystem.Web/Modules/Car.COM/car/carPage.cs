using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace serenity_carsystem.Car.COM.Pages;

[PageAuthorize(typeof(carRow))]
public class carPage : Controller
{
    [Route("Car.COM/car")]
    public ActionResult Index()
    {
        return this.GridPage("@/Car.COM/car/carPage",
            carRow.Fields.PageTitle());
    }
}