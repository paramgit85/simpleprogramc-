using FindDistanceApp.Controllers;
using GeoCoordinatePortable;

namespace FindDistanceApp.Services
{
    public class FindDistance : IFindDistance
    {
        private readonly ILogger<FindDistance> _logger;
        public FindDistance(ILogger<FindDistance> logger)
        {
            _logger = logger;
        }

        public double CalculateDistance(double Originlat, double Originlng, double Destinationlat, double Destinationlng)
        {

            var origin = new GeoCoordinate(Originlat, Originlng);
            var destin = new GeoCoordinate(Destinationlat, Destinationlng);            

            return  Math.Round(origin.GetDistanceTo(destin)/1000,2);
        }


        public double HaversineCalculateDistance(double Originlat, double Originlng, double Destinationlat, double Destinationlng)
        {
            return Haversine.calculate(Originlat, Originlng, Destinationlat, Destinationlng);
        }


        


    }
}
