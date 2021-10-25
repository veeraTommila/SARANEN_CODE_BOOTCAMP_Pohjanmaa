using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muuttujat. The variables.            
            Console.WriteLine("Hello! Are you ready to continue? Yes / No ? Please answer.");            
            string answer = Console.ReadLine(); //Reads inputs of a keyboard. 
            int number = 256;            
    
            if(answer=="yes" || answer=="Yes")
            {
                Console.WriteLine("You chose yes");
            }else if(answer=="no" || answer=="No")
            {
                Console.WriteLine("You chose no");
            }else
            {
                Console.WriteLine("No selection.");
            }
            //This will be printed after your choise notation.
            //Tämä tulostuu valintailmoituksen jälkeen.
            Console.WriteLine(number);
        }
    }
}
