using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "pradnya", 25, 5.9, 70);
            Person person2 = new Person(2, "aryaa", 30);

            person1.DisplayInfo();
            Console.WriteLine($"BMI: {person1.CalculateBMI():F2}");
            Console.WriteLine($"Body Type: {person1.GetBodyType()}");
            Console.WriteLine();

            person2.DisplayInfo();
            Console.WriteLine($"BMI: {person2.CalculateBMI():F2}");
            Console.WriteLine($"Body Type: {person2.GetBodyType()}");
        }
    }
}
