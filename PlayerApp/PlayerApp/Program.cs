using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Pradnya", 25);
            Player player2 = new Player(2, "Pranav", 30);

            player1.Display();
            player2.Display();

            Player elder = player1.WhoIsElder(player2);
            Console.WriteLine($"Elder Player: {elder.GetName()}");
        }
    }
}
