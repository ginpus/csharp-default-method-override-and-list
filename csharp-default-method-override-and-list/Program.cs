using System;

namespace csharp_lecture_12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var car1 = new Car("LRS752", "Bugatti");
            var car2 = new Car("LDI654", "VW");
            var car3 = new Car("LIB045", "GAZ");
            var car4 = new Car("CDI004", "Tatta");

            var carpark = new CarPark();

            carpark.AddCar(car1.ToString());
            carpark.AddCar(car2.ToString());
            carpark.AddCar(car3.ToString());
            carpark.AddCar(car4.ToString());

            carpark.ToString();

            //carpark.AddCar(car1);
            //carpark.AddCar(car2);
            //carpark.AddCar(car3);
            //carpark.AddCar(car4);

            //Console.WriteLine(carpark.ToString());
        }
    }
}