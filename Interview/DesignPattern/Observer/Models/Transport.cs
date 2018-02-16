using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DesignPattern.Observer.Models
{
    public abstract class Transport
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public Transport(string number, string name, double distance, DateTime departure, DateTime arrival)
        {
            this.Name = name;
            this.Number = number;
            this.Distance = distance;
            this.DepartureTime = departure;
        }

    }
}
