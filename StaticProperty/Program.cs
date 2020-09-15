using System;

namespace StaticProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mazda 3", "Skyactiv 3");
            Console.WriteLine(Car.numberOfCars);
            Car car2 = new Car("Mazda 1", "Skyactiv 4");
            Console.WriteLine(Car.numberOfCars);
            Car car3 = new Car("Mazda 2", "Skyactiv 5");
            Console.WriteLine(Car.numberOfCars);
            Car car4 = new Car("Mazda 4", "Skyactiv 6");
            Console.WriteLine(Car.numberOfCars);
            Console.ReadLine();
        }
    }
}
