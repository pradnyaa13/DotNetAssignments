using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int element = 8; 
            int firstElement = 1, secondElement = 1;

            Console.Write(firstElement + " " + secondElement + " "); 

            for (int i = 3; i <= element; i++)
            {
                int next = firstElement + secondElement;
                Console.Write(next + " ");
                firstElement = secondElement;
                secondElement = next;
            }
        }
    }
}
