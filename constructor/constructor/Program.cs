using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        //constructor chaining
        public Program():this(10) {  //this fuction 
            Console.WriteLine("No argument");
        }    
        public Program(int num):this("Ram") {
            
            Console.WriteLine("int argument");
        }

        public Program(String str)
        {
            Console.WriteLine("String argument");
        }
        static void Main(string[] args)
        {
            Program ob1= new Program();
            //Program ob1 = new Program(1);
            //Program ob1 = new Program("helllo");
        }
    }
}
