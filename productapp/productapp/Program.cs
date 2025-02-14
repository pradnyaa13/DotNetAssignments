using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product productobj = new Product(1,"MILTONBOTTLE",1200,10);

            Product[] products = new Product[]
            {
                new Product(1, "MILTONBOTTLE", 1200, 10),
                new Product(2, "THERMOS", 1800, 15),
                new Product(3, "STEELBOTTLE", 500, 5),
                new Product(4, "MUG", 300, 20)

            };
            //products[0] = new Product(1, "MILTONBOTTLE", 1200, 10);
            //products[1] = new Product(2, "THERMOS", 1800, 15);
            //products[2] = new Product(3, "STEELBOTTLE", 500, 5);
            //products[3] = new Product(4, "MUG", 300, 20);

            foreach (Product p in products)
            {
                p.DisplayProductDetails();
            }
        }

        
    }
}
