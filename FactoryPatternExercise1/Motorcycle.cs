using System;
namespace FactoryPatternExercise1
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("You have chosen a motorcycle.");
            Console.WriteLine("It's so loud!");
        }
    }
}
