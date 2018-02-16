using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.DesignPattern
{
    public class Singleton
    {
        private static object syncRoot = new Object();

        private Singleton()
        {
            list = new LinkedList<string>(words.ToList());
        }

        private static Singleton _instance = null;

        string[] words = { "the", "fox", "jumped", "over", "the", "dog" };

        LinkedList<string> list = null;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }

                return _instance;
            }
        }

        public string getWordFromList()
        {
            string word = string.Empty;

            if (list.Count > 0)
            {
                word = list.First.Value;
                list.RemoveFirst();
            }

            return word;
        }
    }
}
