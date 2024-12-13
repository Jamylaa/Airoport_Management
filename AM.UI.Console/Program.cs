// See https://aka.ms/new-console-template for more information
using AM.ApllicationCore.Domain;
using System;
using Plane = System.Numerics.Plane;

using AM.ApllicationCore;
using System.Numerics;

Console.WriteLine( " Hello, Joujou ! " );

//instantation 
//Plane plane1 = new Plane();
//plane1.PlaneType = PlaneType.Airbus;
//plane1.Capacity = 200;
//plane1.ManufactureDate = new DateTime(2018, 11, 10);



Passenger passenger = new Passenger
{
    PasseportNumber = "4",
    FirstName = "Alice",
    LastName = "Dridi",
    TelNumber = 97765333,
    EmailAdress= "Benabdeljamyla@gmail.com",
    BirthDate= new DateTime(2001, 08, 24)
};
Staff staff1 = new Staff
{
    PasseportNumber = "887",
    FirstName = "3abl9ader",
    LastName = "Jack",
    TelNumber = 97243555,
    EmailAdress = "BenabdelJack@gmail.com",
    BirthDate = new DateTime(2006, 06, 26)
};


Traveller traveller = new Traveller {
    PasseportNumber = "99",
    FirstName = "Emily",
    LastName = " Riden ",
    TelNumber = 99843967,
    EmailAdress = "EMilyRiden@gmail.com",
    BirthDate = new DateTime(2000, 01, 1)
};




Plane plane = new Plane{
   PlaneId = 112,
   PlaneType = PlaneType.Airbus,
    Capacity = 200,
    ManufactureDate = new DateTime(2018, 11, 10)
};


Plane plane1 = new Plane();


Plane plane2 = new Plane();
//(PlaneId, PlaneType planeType, int capacity, DateTime manufactureDate)
{
    2,
    PlaneType.boing,
    300,
    DateTime.Now
    };


Plane plane2 = new Plane() {
    PlaneId = 22,
    766,
    PlaneType.Airbus,
    DateTime.Now)
};

Plane plane3 = new Plane {
    PlaneId = 3,
    PlaneType = PlaneType.Airbus,
    Capacity = 150,
    ManufactureDate = new DateTime(2015, 02, 03) };

// Création de l'objet à l'aide du constructeur non paramétré

// Initialisation des propriétés
Plane plane5 = new Plane();
plane5.Capacity = 180;
plane5.ManufactureDate = new DateTime(2018, 5, 20);
plane5.PlaneID = 1;
plane5.PlaneType = PlaneType.boing;

// Affichage des propriétés pour vérifier
Console.WriteLine($"Plane [ID={plane5.PlaneId}," +
    $" Type={plane5.PlaneType}," +
    $" Capacity={plane5.Capacity}," +
    $" ManufactureDate={plane.ManufactureDate:yyyy-MM-dd}]");


Console.WriteLine(plane);
Console.WriteLine(plane1);
Console.WriteLine(plane2);
Console.WriteLine(plane3);
Console.WriteLine(plane5);

Console.WriteLine(staff1);
Console.WriteLine(traveller);
Console.WriteLine(passenger);


FlightMethods fm = new FlightMethods();
fm.Flights = TestData.listFlights;
string destination = "Paris";
List<DateTime> flightDates = FlightMethods.GetFlightDatesByDestination(destination);

Console.WriteLine($"Flight dates to {destination}:");
foreach (var date in flightDates)
{
    Console.WriteLine(date.ToString("yyyy-MM-dd"));
}