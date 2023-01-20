using System;

namespace Brogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikatorn 3000. Skriv nummer separerade med * för att multiplicera");
            string[] sträng = Console.ReadLine().Split("*");
            Int64[] nummer = Array.ConvertAll(sträng, s => Int64.Parse(s)); // Använder Int64 så att man kan multiplicera större tal
            Int64 x = 1;
            foreach (Int64 i in nummer)
            {   x = x * i;  }
            Console.WriteLine(x);
            
        }
    }
}
