using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public enum PlaneType{
        boing , Airbus
        
    }
  public class Plane
    {
       public int PlaneID {  get; set; }
        public int Capacity { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }

        public ICollection<Flight>flights { get; set; }
        public override string ToString()
        {
            return
                "PlaneId:" + PlaneID
                + "Capacity:" + Capacity
                + "PlaneType: " + PlaneType
                + "ManufactureDate:" + ManufactureDate;
        }
       

        public Plane() { }


        public Plane(int PlaneId , PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            PlaneID = PlaneID;
            Capacity = capacity;
            PlaneType = planeType;
            ManufactureDate = manufactureDate;
        }


        

    }
}
