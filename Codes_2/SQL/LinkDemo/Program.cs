using System;
using System.Linq;
namespace LinkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Perinteinen ohjelmointitapa. Display numbers.
            int[] numerot = { 3, 6, 9, 13, 2, 4, 43, 18 };
            //Sort from smaller to larger.
            Array.Sort(numerot);
            foreach(int numero1 in numerot)
            {
                if(numero1 > 9)
                {
                    Console.WriteLine("Numero: " + numero1);
                }
            }

            //Linq demo
            int [] numerot2 = { 3, 6, 9, 13, 2, 4, 43, 18 };
            //Sort from smaller to larger.
            var largerthanFive = (from tilaus in numerot2 //tilaus on vain tilapäinen muuttuja.
                                  where tilaus > 5
                                  orderby tilaus
                                  select tilaus);
            foreach (int numero2 in largerthanFive)
            {
                Console.WriteLine("Numero nyt: " + numero2);
            }
        }
    }
}
