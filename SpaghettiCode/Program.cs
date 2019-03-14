using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zamawiam kawę; dużą 200ml; Z mlekiem; 50ml; Z cukrem; 2 kostki.");
            var coffee = new Drink(3, 4, 5, 1, 20, 2).Create();
            Console.WriteLine(coffee);
            Console.Read();
            //Wynik:
            //Kawa; duża 200 ml; z mlekiem 50 ml; z cukrem 2 kostki.

        }
    }
}
