using System;
using System.IO;

namespace FileSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "D:\\Tiedostot\\SARANEN_CODE_BOOTCAMP_Pohjanmaa\\Codes_2\\DotNet\\Numbers.txt";
            string[] lines = File.ReadAllLines(filename);
            int sum = 0;
            foreach (string line in lines)
            {
                int value = int.Parse(line);
                sum += value;
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
