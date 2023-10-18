namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many tires do you want on your vehicle?");
            string answer = Console.ReadLine().ToString();

            IVehicle chosenVehicle = VehicleFactory.GetVehicle(answer);
            chosenVehicle.Drive();
        }
    }
}
