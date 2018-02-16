using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.DesignPattern.Observer.Models;

namespace Interview.DesignPattern.Observer
{
    public interface Publisher
    {
        void Register(Consumer consumer);
        void UnRegister(Consumer consumer);
        void NotifyUpdate(Transport flight);
    }
}
