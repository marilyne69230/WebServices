using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Controllers
{
    public class CitiesController : ControllerBase
    {
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<Object>
                {
                    new {id=1, name="New York City"},
                    new {id=2, name="Antwerp"}
                }
                );
        }
    }
}
