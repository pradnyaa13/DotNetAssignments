using System;

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

        // Constructor chaining calls the main constructor with default age = 0
        public Player(int id, string name) : this(id, name, 0)
        {
        }

        public int GetId() { return id; }
        public string GetName() { return name; }
        public int GetAge() { return age; }

        public Player WhoIsElder(Player other)
        {
            return this.age >= other.age ? this : other;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
    }
}
