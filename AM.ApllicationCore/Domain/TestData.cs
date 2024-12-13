using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public static class TestData
    {
        // Planes 
        public static Plane AirbusPlane = new Plane { PlaneType = PlaneType.Airbus, Capacity = 990, ManufactureDate = new DateTime(2024, 04, 04) };
        public static Plane Boingplane = new Plane { PlaneType = PlaneType.boing, Capacity = 970, ManufactureDate = new DateTime(2025, 12, 12) };
        public static Plane AirbusPlane1 = new Plane { PlaneType = PlaneType.Airbus, Capacity = 230, ManufactureDate = new DateTime(2020, 02, 02) };


        // Staffs

        public static Staff Capitaine = new Staff {FirstName = "Jamila" , LastName ="Ben Abdelkader", EmailAdress="Benabdeljamyla@esprit.tn", BirthDate= new DateTime(2001,08,24), EmploymentDate= new DateTime(2020,12,12), Salary=12887 };
        public static Staff captain = new Staff { FirstName = "Ali", LastName = "Aloui", EmailAdress = "Ali.Aloui@hotmail.com", BirthDate = new DateTime(1966, 08, 08), EmploymentDate = new DateTime(1999, 01, 01), Salary = 66777 };
        public static Staff hotess1 = new Staff { FirstName = "Hajer", LastName = "Riden", EmailAdress = "Hajer.Riden@gmail.com", BirthDate = new DateTime(1978, 09, 19), EmploymentDate = new DateTime(2022, 05, 04), Salary = 5599 };
        public static Staff Estiward = new Staff { FirstName = "Samir", LastName = "Smiri", EmailAdress = "SamirSmiri@gmail.com", BirthDate = new DateTime(1987, 05, 19), EmploymentDate = new DateTime(2023, 04, 04), Salary = 4488 };
        
        // Travellers
        public static Traveller traveller1 = new Traveller { FirstName = "Jamil", LastName = "Ben Abdelkader", EmailAdress = "traveller1.traveller1@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "no troubles", Nationality = "Tunisian" };
        public static Traveller traveller2 = new Traveller { FirstName = "Leila", LastName = "Youssef", EmailAdress = "traveller2.traveller2@gmail.com", BirthDate = new DateTime(1981, 01, 01), HealthInformation = "Some troubles", Nationality = "Algerian" };
        public static Traveller traveller3 = new Traveller { FirstName = "Arij", LastName = "Abdellaoui", EmailAdress = "traveller3.traveller3@gmail.com", BirthDate = new DateTime(1982, 01, 01), HealthInformation = "Panick Attack", Nationality = "Candian" };
        public static Traveller traveller4 = new Traveller { FirstName = "Seif", LastName = "Bissa", EmailAdress = "traveller4.traveller4@gmail.com", BirthDate = new DateTime(1983, 01, 01), HealthInformation = "Diabetic", Nationality = "French" };
        public static Traveller traveller5 = new Traveller { FirstName = "Ayoub", LastName = "Gombra", EmailAdress = "traveller5.traveller5@gmail.com", BirthDate = new DateTime(1984, 01, 01), HealthInformation = "Fine", Nationality = "Spanish" };


        // Flights

        // Affect all passengers to flight1

        public static Flight flight1 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 03),
            EstimatedDuration = 110,
            passengers = new List<Passenger> { Capitaine, hotess1, Estiward, traveller1, traveller2, traveller3, traveller4, traveller5 },
            planes = AirbusPlane1
        };


        public static Flight flight2 = new Flight { FlightDate = new DateTime(2022, 02, 01, 21, 10, 10), Destination = "Paris", EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10), EstimatedDuration = 105, planes =AirbusPlane1 };
        public static Flight flight3 = new Flight { FlightDate = new DateTime(2022, 03, 01, 5, 10, 10), Destination = "Paris", EffectiveArrival = new DateTime(2022, 03, 01, 6, 40, 10), EstimatedDuration = 100, planes = BoingPlane };
        public static Flight flight4 = new Flight { FlightDate = new DateTime(2022, 04, 01, 6, 10, 10), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 04, 01, 8, 10, 10), EstimatedDuration = 130, planes = BoingPlane };
        public static Flight flight5 = new Flight { FlightDate = new DateTime(2022, 05, 01, 17, 10, 10), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 05, 01, 18, 50, 10), EstimatedDuration = 105, planes = BoingPlane };
        public static Flight flight6 = new Flight { FlightDate = new DateTime(2022, 06, 01, 20, 10, 10), Destination = "Lisbonne", EffectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10), EstimatedDuration = 200, planes = Airbusplane };

        //tester  list
        public static List<Flight> Flights = new List<Flight> { flight1, flight2, flight3, flight4, flight5, flight6 };

        public static List<Flight> listFlights = new List<Flight> { flight1, flight2,
flight3, flight4, flight5, flight6 };
    
    }


}