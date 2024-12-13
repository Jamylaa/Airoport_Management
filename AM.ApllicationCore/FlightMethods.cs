using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Interfaces;

namespace AM.ApllicationCore
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; }  = new List<Flight> ();


        public List<Flight> listFlight { get; set; }
        = new List<Flight>();


        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> ls = new List<DateTime>();
            foreach (Flight f in Flights)
            {
                if (f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))  
                    // Comparaison
                {
                    ls.Add(f.FlightDate);
                }
            }
            return ls;
        }





    }
}