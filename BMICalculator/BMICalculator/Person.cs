using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person(int id, string name, int age, double height, double weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

       
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = 5;  
            Weight = 50; 
        }

        
        public double CalculateBMI()
        {
            
            double heightInMeters = Height * 0.3048;
            
            return Weight / (heightInMeters * heightInMeters);
        }

       
        public string GetBodyType()
        {
            double bmi = CalculateBMI();

            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 24.9)
                return "Normal weight";
            else if (bmi >= 25 && bmi < 29.9)
                return "Overweight";
            else
                return "Obese";
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Height: {Height} feet");
            Console.WriteLine($"Weight: {Weight} kg");
        }
    }
}
