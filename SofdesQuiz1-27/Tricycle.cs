namespace SofdesQuiz1_27;

public class Tricycle : TransportationVehicle{
    public override void FareRate() {
        Console.WriteLine("Tricycle fixed rate is : 100");
    }
    public override void Move() {
        Console.WriteLine("The Tricycle is Moving......");
    }
}