using Microsoft.AspNetCore.Mvc;

namespace FindDistanceApp.Services
{
    public interface IFindDistance
    {
        public double CalculateDistance( double Originlat,  double Originlng,
            double Destinationlat,  double Destinationlng);

        public double HaversineCalculateDistance(double Originlat, double Originlng,
            double Destinationlat, double Destinationlng);
    }
}
