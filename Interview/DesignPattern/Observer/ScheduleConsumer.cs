using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.DesignPattern.Observer.Models;

namespace Interview.DesignPattern.Observer
{
    class ScheduleConsumer : Consumer
    {
        // Used to keep track of consumer id.
        public static int ConsumerIdTracker = 0;

        // Each object's id
        public int ConsumerId = 0;

        public ScheduleConsumer()
        {
            ConsumerId = ++ConsumerIdTracker;
        }

        public SchedulePublisher SchPublisher { get; set; }

        public void Update(Transport flight)
        {
            Console.WriteLine("Consumer Id: " + ConsumerId);
            Console.WriteLine("Flight Name: " + flight.Name);
            Console.WriteLine("Flight Name: " + flight.Distance);
        }
    }
}
