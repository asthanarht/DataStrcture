using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.DesignPattern.Observer.Models;

namespace Interview.DesignPattern.Observer
{
    class SchedulePublisher : Publisher
    {
        List<Consumer> consumerList;
        List<Transport> transportList;

        public double FlightBADistance
        {
            set
            {
                flightBA.Distance = value;
                NotifyUpdate(flightBA);
            }
        }

        public double FlightAnaDistance
        {
            set
            {
                flightAna.Distance = value;
                NotifyUpdate(flightAna);
            }
        }

        public double FlightAIDistance
        {
            set
            {
                flightAI.Distance = value;
                NotifyUpdate(flightAI);
            }
        }

        Transport flightBA, flightAna, flightAI;

        public SchedulePublisher()
        {
            consumerList = new List<Consumer>();
            flightBA = new Flight("BA147", "BA", 1000, DateTime.Now, DateTime.Now);
            flightAna = new Flight("ANA49", "ANA", 1200, DateTime.Now, DateTime.Now);
            flightAI = new Flight("AI27", "AI", 1400, DateTime.Now, DateTime.Now);
        }

        public void Register(Consumer consumer)
        {
            consumerList.Add(consumer);
        }

        public void UnRegister(Consumer consumer)
        {
            int position = consumerList.IndexOf(consumer);

            Console.WriteLine("Consumer being deleted: " + position);

            consumerList.Remove(consumer);
        }

        public void NotifyUpdate(Transport flight)
        {
            foreach (Consumer consumer in consumerList)
            {
                consumer.Update(flight);
            }
        }

    }
}
