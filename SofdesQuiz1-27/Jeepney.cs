namespace SofdesQuiz1_27;

public class Jeepney : TransportationVehicle{
    public override void FareRate() {
        Console.WriteLine("Jeepney fixed rate is : 50");
    }
    public override void Move() {
        Console.WriteLine("The Jeepney is Moving......");
    }
}