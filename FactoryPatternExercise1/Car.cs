using System;
namespace FactoryPatternExercise1
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("You have chosen a car!");
            Console.WriteLine("VROOOOM!!");
        }
    }
}
