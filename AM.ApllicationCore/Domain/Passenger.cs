using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public string PasseportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public string EmailAdress { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Flight> Flights { get; set; }


        public override string ToString()
        {
            return "PasseportNumber:" +PasseportNumber
                +"FirstName: " + FirstName
                +"LastName:" +LastName
                +"TelNumber:" + TelNumber
                + "EmailAdress:" +EmailAdress
                +"BirthDate: " + BirthDate ;
        }

        public bool ChechkProfile(string firstName, string lastName, string EmailAdress)
        {

            return FirstName == firstName
                && LastName == lastName 
                && EmailAdress== EmailAdress;

        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a Passenger ! ");
        }

    }
}