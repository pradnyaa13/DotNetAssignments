using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[]
            {
            new Student(101, "Pradnya", 8.5),
            new Student(102, "Sau", 9.0),  
            new Student(103, "Aryaa", 11), 
            new Student(-1, "Vishlesha", 7.5) 
            };

            foreach (var student in students)
            {
                PrintStudentInfo(student);
                Console.WriteLine();
            }

        }
       public static void PrintStudentInfo(Student student)
        {
            student.DisplayStudentInfo();
        }
        }

    }

