using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    public class SallariedEmploye : Person
    {
        public double BasicSalary { get; set; }

       public SallariedEmploye(int id, string address, DateTime dob, double basicSalary) : base(id, address, dob)
        {
            BasicSalary = basicSalary;
        }

        public virtual double CalculateSalary()
        {
            return BasicSalary; 
        }
    }
}

