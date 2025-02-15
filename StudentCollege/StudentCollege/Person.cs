﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    public class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }

        public Person(int id, string address, DateTime dob)
        {
            Id = id;
            Address = address;
            DOB = dob;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Address: {Address}, DOB: {DOB.ToShortDateString()}");
        }
    }
}
