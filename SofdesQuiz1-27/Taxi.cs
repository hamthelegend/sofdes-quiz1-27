namespace SofdesQuiz1_27;

public class Taxi : TransportationVehicle{
    public override void FareRate() {
        Console.WriteLine("Taxi fixed rate is : 200");
    }
    public override void Move() {
        Console.WriteLine("The Taxi is Moving......");
    }
}