using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string thing = Console.ReadLine();

            string OtherThing = Console.ReadLine();
            Console.WriteLine("this {0} and this other {1}",thing,OtherThing);
            Console.WriteLine($"this {thing} and this other {OtherThing}");
            Console.ReadKey();
        }
    }
}
