using Microsoft.AspNetCore.Mvc;

namespace Zadanie7.Controllers;

[Route("api/trip")]
public class TripsController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetTrips()
    {
        return Ok();
    }
}