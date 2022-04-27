// See https://aka.ms/new-console-template for more information

using SofdesQuiz1_27;

TransportationVehicle[] vehicles = { new Taxi(), new Bus(), new Tricycle(), new Jeepney() };
foreach (var vehicle in vehicles) {
    vehicle.FareRate();
    vehicle.Move();
}