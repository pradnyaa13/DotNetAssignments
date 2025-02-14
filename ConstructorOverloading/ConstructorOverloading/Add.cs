using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Add
    {
        int x, y;
        double f;
        string s;

        
        public Add(int a, double b)
        {
            x = a;
            f = b;
        }

        
        public Add(int a, string b)
        {
            y = a;
            s = b;
        }
        public void show()
        {
            Console.WriteLine("1st constructor is (int + float): {0} ", (x + f));

        }

     
        public void show1()
        {
            Console.WriteLine("2nd constructor is  (int + string): {0}", (s + y));

        }
    }
}
