using System;

namespace DotNet
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Muuttujat. The variables.
            String tervehdys = ("Tervehdys kaikille!");
            int numero = 12;
            float desimaali = 30.24f;
            char merkki = 'Ä';

            //Tulostuskomennot. The print commands.
            Console.WriteLine("How are you?");
            Console.WriteLine(tervehdys);
            Console.WriteLine("Numero on: "+ numero);
            Console.WriteLine("Float-numero on: " +desimaali);
            Console.WriteLine("Char on: " + merkki);
        }
    }
}
