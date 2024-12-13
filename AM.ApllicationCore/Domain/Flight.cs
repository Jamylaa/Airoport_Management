using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival {  get; set; }
        public List <Plane> planes {  get; set; }
        public ICollection <Passenger> passengers { get; set; }
      

        public override String ToString()
        {
            return "FlightId: " + FlightId
                + "Departure: " + Departure
                + "Destination: " + Destination
                + "FlightDate: " + FlightDate
                + "EstimatedDuration: " + EstimatedDuration;

        }

        public Flight() { }

        public Flight(int FlightId,string Departure, string Destination, DateTime FlightDate, int EstimatedDuration , DateTime EffectiveArrival)
        {
           this.FlightId = FlightId;
            this.Departure = Departure;
            this.Destination = Destination;
            this.FlightDate = FlightDate;
            this.EstimatedDuration = EstimatedDuration;
            this.EffectiveArrival = EffectiveArrival ;
             }



    }
}
