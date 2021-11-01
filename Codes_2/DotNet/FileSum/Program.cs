using System;
using System.IO;

namespace FileSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Haloo!\"");
            Console.WriteLine("'Haloo!'\n");
            string filename = "D:\\Tiedostot\\SARANEN_CODE_BOOTCAMP_Pohjanmaa\\Codes_2\\DotNet\\Numbers.txt";
            string[] lines = File.ReadAllLines(filename);
            
            int sum = 0;
            int currentLine = 1;
            foreach (string line in lines)
            {
                //Exception handling. Accept invalid data.
                //Catch any errors of the code.
                try
                {
                    int value = int.Parse(line);
                    sum += value;
                    Console.WriteLine("The line: "+line);
                }
                catch //If nothing success.
                {                    
                    Console.WriteLine("Cannot process the line \"" + currentLine + 
                    " with value \"" + line + "\", not a valid number.");
                }
                currentLine++;
            }
            


            
            /*
            for (int index = 0; index < lines.Lenght; index ++)
            {
                string line lines = lines[index];
                int value = int.Parse(line);
                sum += value;
            }
            */
            

            Console.WriteLine("Calculated sum is:" + sum);
        }
    }
}
