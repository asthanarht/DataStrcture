using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interview.DesignPattern.Strategy;
using Interview.DesignPattern;
using Interview.DesignPattern.Observer;

namespace Interview
{
    public partial class DesignPatterns : Form
    {
        public DesignPatterns()
        {
            InitializeComponent();
        }

        private void Strategy_Click(object sender, EventArgs e)
        {
            Automobile bajajPulsar = new BajajPulsar();
            Automobile marutiAlto = new MarutiAlto();

            bajajPulsar.PrintWheelType();
            marutiAlto.PrintWheelType();
        }

        private void Singleton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Singleton.Instance.getWordFromList());
        }

        private void Observer_Click(object sender, EventArgs e)
        {
            SchedulePublisher publisher = new SchedulePublisher();

            ScheduleConsumer consumer = new ScheduleConsumer();
            consumer.SchPublisher = publisher;
            publisher.Register(consumer);

            publisher.FlightAIDistance = 1400;
            publisher.FlightBADistance = 900;
            publisher.FlightAnaDistance = 1200;

            publisher.FlightAIDistance = 1000;
            publisher.FlightBADistance = 800;
            publisher.FlightAnaDistance = 1100;

            ScheduleConsumer consumer1 = new ScheduleConsumer();
            consumer1.SchPublisher = publisher;
            publisher.Register(consumer1);

            publisher.FlightAIDistance = 800;
            publisher.FlightBADistance = 600;
            publisher.FlightAnaDistance = 900;
        }
    }
}
