namespace SofdesQuiz1_27;

public class Bus : TransportationVehicle{
    public override void FareRate() {
        Console.WriteLine("Bus fixed rate is : 150");
    }

    public override void Move() {
        Console.WriteLine("The Bus is Moving......");
    }
}