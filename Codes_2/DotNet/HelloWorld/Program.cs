using System;

namespace HelloWorld
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
            string YesNo = Console.ReadLine();
            
            //Tulostuskomennot. The print commands.
            Console.WriteLine("How are you?");
            Console.WriteLine(tervehdys);
            Console.WriteLine("Numero on: "+ numero);
            Console.WriteLine("Float-numero on: " +desimaali);
            Console.WriteLine("Char on: /n" + merkki);
            //Tulostuskomennot. The print commands.
            Console.WriteLine("How are you?");
            Console.WriteLine(tervehdys);
            Console.WriteLine("Numero on: "+ numero);
            Console.WriteLine("Float-numero on: " +desimaali);
            Console.WriteLine("Char on: " + merkki);
            Console.WriteLine(" ");

            Console.WriteLine("Are you ready to continue? Yes / No ? Please answer.");
            if(YesNo=="yes")
            {
                Console.WriteLine("You chose yes");
            }else if(YesNo=="no")
            {
                Console.WriteLine("You chose no");
            }else
            {
                Console.WriteLine("No selection.");
            }


        }
    }
}
