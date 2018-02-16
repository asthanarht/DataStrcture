using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DesignPattern.Strategy
{
    public class BajajPulsar : Automobile
    {
        public BajajPulsar()
        {
            wheelType = new _WheelsTwo();
        }
    }
}
