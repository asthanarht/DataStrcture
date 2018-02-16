using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DesignPattern
{
    public class ClassPractise
    {
        public class baseclass
        {
            public int number;
        }

        public int returnNumber ()
        {
            baseclass x = new baseclass();
            baseclass y = new baseclass();

            x.number = 4;
            y = x;
            y.number = 3;

            return x.number;
        }
    }
    
    
}
