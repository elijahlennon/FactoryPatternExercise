using System;

namespace FactoryPatternExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Let's build a new car! Enter the amount of wheels for the vehicle that you would like to create");
                input = int.TryParse(Console.ReadLine(), out wheelCount);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);

            vehicle.Drive();


            
            

        }
    }
}
