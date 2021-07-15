using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_12
{
    internal class Car
    {
        private string _id;
        private string _make;

        public override string ToString()
        {
            var carData = $"Car ID: {_id}; Make: {_make}";
            return carData;
        }

        public Car(string id, string make)
        {
            _id = id;
            _make = make;
        }
    }
}