using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DesignPattern.Strategy
{
    class MarutiAlto : Automobile
    {
        public MarutiAlto()
        {
            wheelType = new _WheelsFour();
        }
    }
}
