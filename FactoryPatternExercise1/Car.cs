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
            Console.WriteLine("This car is working properly.");
        }
    }
}
