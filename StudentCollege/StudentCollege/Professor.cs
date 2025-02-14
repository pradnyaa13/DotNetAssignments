using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    public class Professor : SallariedEmploye
    {
        public double Bonus { get; set; }

        public Professor(int id, string address, DateTime dob, double basicSalary, double bonus)
            : base(id, address, dob, basicSalary)
        {
            Bonus = bonus;
        }

       
        public override double CalculateSalary()
        {
            return BasicSalary + Bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Basic Salary: {BasicSalary}, Bonus: {Bonus}, Total Salary: {CalculateSalary()}");
        }
    }
}
