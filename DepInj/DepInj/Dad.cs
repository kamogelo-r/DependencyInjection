using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj
{    
    public class Dad
    {
        public ISon Son { get; set; } //property dependency injection

        ISon son = null;

        public Dad(ISon selectedSon) //ctor dependency injection
        {
            son = selectedSon;
        }
        public void Notify(/*string message,*/ ISon selectedSon) //method dependency injection
        {
            if (selectedSon /*Son*/ == null)
            {
                Console.WriteLine("Dad needs help");
            }

            //son.Help(message);
            //selectedSon.Help(message);
              //Son.Help(message);
        }
    }

    public class EldestSon : ISon
    {
        public void Help(string message)
        {
            Console.WriteLine("Eldest Son to the rescue");
        }
    }

    public class YoungestSon: ISon
    {
        public void Help(string message)
        {
            Console.WriteLine("Youngest Son to the rescue");
        }
    }

    public interface ISon
    {
        void Help(string message);
    }
}
