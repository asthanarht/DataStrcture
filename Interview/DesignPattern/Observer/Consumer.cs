using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.DesignPattern.Observer.Models;

namespace Interview.DesignPattern.Observer
{
    public interface Consumer
    {
        void Update(Transport flight);
    }
}
