using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Student student = new Student(101, "Mumbai", new DateTime(2002, 5, 15), "Computer Engineering");
            Console.WriteLine("Student Details:");
            student.DisplayInfo();
            Console.WriteLine();

          
            Professor professor = new Professor(201, "Pune", new DateTime(1980, 8, 20), 70000, 10000);
            Console.WriteLine("Professor Details:");
            professor.DisplayInfo();
        }
    }
}
