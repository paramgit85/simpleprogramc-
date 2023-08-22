using FindDistanceApp.Models;
using FindDistanceApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindDistanceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceController : ControllerBase
    {
        private readonly IFindDistance findDistance;
        private readonly ILogger<DistanceController> _logger;
        public DistanceController(IFindDistance distance, ILogger<DistanceController> logger) 
        {
            findDistance = distance;
            _logger = logger;
        }       


        [HttpGet(Name = "Distance")]
        public IActionResult FindDistanceByCoordinate([FromQuery] double Originlat, [FromQuery] double Originlng, 
            [FromQuery] double Destinationlat, [FromQuery] double Destinationlng)
        {
                
                var distanceValue = findDistance.CalculateDistance(Originlat, Originlng, Destinationlat, Destinationlng);
            return Ok(new ResponseModel() { DistanceInKM = distanceValue });

            //var distanceValue2 = findDistance.HaversineCalculateDistance(Originlat, Originlng, Destinationlat, Destinationlng);


        }

    }
}
