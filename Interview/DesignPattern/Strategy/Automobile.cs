using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.DesignPattern.Strategy;

namespace Interview.DesignPattern.Strategy
{
    public class Automobile
    {
        public string LicNumber { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }

        public _WheelType wheelType { get; set; }

        public void PrintWheelType()
        {
            if (wheelType != null)
                Console.WriteLine(wheelType.wheels());
        }
    }
}
