using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Player
    {
        private int id;
        private string name;
        private int age;

       
        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        
        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.age = 0;
        }

      
        public int GetId() { return id; }
        public string GetName() { return name; }
        public int GetAge() { return age; }

     
        public Player WhoIsElder(Player other)
        {
            if (this.age >= other.age)
                return this;
            else
                return other;
        }

   
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
    }
}
