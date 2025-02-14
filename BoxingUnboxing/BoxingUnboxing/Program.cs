using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 42;
            object objInt = num;  // Boxing
            int unboxedNum = (int)objInt;  // Unboxing
            Console.WriteLine("For int:");
            Console.WriteLine("Boxed int: " + objInt);
            Console.WriteLine("Unboxed int: " + unboxedNum);

            double price = 19.99;
            object objDouble = price; 
            double unboxedDouble = (double)objDouble;  
            Console.WriteLine("\nFor double:");
            Console.WriteLine("Boxed double: " + objDouble);
            Console.WriteLine("Unboxed double: " + unboxedDouble);

            char letter = 'A';
            object objChar = letter;  
            char unboxedChar = (char)objChar;  
            Console.WriteLine("\nFor char:");
            Console.WriteLine("Boxed char: " + objChar);
            Console.WriteLine("Unboxed char: " + unboxedChar);

            bool isAvailable = true;
            object objBool = isAvailable;  // Boxing
            bool unboxedBool = (bool)objBool;  // Unboxing
            Console.WriteLine("\nFor bool:");
            Console.WriteLine("Boxed bool: " + objBool);
            Console.WriteLine("Unboxed bool: " + unboxedBool);

        }
    }
}
