using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DesignPattern.Observer
{
    public class TransportList
    {
        private static TransportList _instance = null;
        static object syncRoot = new object();

        public static TransportList Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new TransportList();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
