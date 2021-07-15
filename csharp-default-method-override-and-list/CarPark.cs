using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_12
{
    internal class CarPark
    {
        private List<string> _carList;
        //private List<Car> _carList;

        public CarPark()
        {
            _carList = new List<string> { };
            //_carList = new List<Car> { };
        }

        public void AddCar(string car)
        //public void AddCar(Car car)
        {
            _carList.Add(car);
        }

        public override string ToString()
        {
            //var sb = new StringBuilder(); // susikuriam stringbuilder objekta
            //sb.AppendLine("Ammount of cars in car park: " + _carList.Count.ToString());
            //sb.AppendLine("First car in car park: " + _carList[0].ToString());
            //sb.AppendLine("Last car in car park: " + _carList[_carList.Count - 1].ToString());

            Console.WriteLine($"Ammount of cars in car park: {_carList.Count}");
            Console.WriteLine($"First car in car park: {_carList[0]}");
            Console.WriteLine($"Last car in car park: {_carList[_carList.Count - 1]}");
            //foreach (string car in _carList)

            foreach (var car in _carList)
            {
                Console.WriteLine(car);
                //sb.AppendLine(car.ToString());
            }

            return base.ToString();
            //return sb.ToString();
        }
    }
}