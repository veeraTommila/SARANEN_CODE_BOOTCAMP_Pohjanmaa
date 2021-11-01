using System;

namespace DateConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ask the users for two dates. Then calculate the difference of these dates
            in both days and hours.
            */

            // To read the dates from the user.
            //DateTime date1 = ReadDateFromUser("Give me the first date: ");
            Console.WriteLine("Give me the first date: ");
            string dateValue = Console.ReadLine();
            
            //int number = int.Parse(dateValue); //Passing a string value to a number.
            DateTime date1 = DateTime.Parse(dateValue);

            Console.WriteLine("Give me another date: ");
            dateValue = Console.ReadLine();
            DateTime date2 = DateTime.Parse(dateValue);

            /*int aa = 120;
            int bee = 45;
            int difference = aa - bee;
            Dates are related to numbers.*/

            // Date time calculations, substractions. Overloading minus operator.
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + difference.TotalDays);
            Console.WriteLine("Difference in hours: " + difference.TotalHours);
            
            private static DateTime
        }
    }
}
