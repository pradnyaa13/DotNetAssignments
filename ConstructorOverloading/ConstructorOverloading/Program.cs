using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add add = new Add(10, 20.2);
            add.show();

            Add add1 = new Add(10, "Roll No. is ");
            add1.show1();
        }
    }
}
