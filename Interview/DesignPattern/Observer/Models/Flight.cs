using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DesignPattern.Observer.Models
{
    public class Flight : Transport
    {
        public Flight(string number, string name, double distance, DateTime departure, DateTime arrival)
            : base(number, name, distance, departure, arrival)
        {
            
        }
    }
}
