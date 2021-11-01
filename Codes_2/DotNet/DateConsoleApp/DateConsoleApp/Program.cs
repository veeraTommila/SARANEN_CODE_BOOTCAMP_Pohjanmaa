using System;
using System.Globalization;

namespace DateConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ask the users for two dates. Then calculate the difference of these dates
            in both days and hours.
            

            // To read the dates from the user.
            //DateTime date1 = ReadDateFromUser("Give me the first date: ");
            Console.WriteLine("Give me the first date: ");
            string dateValue = Console.ReadLine();
            
            //int number = int.Parse(dateValue); //Passing a string value to a number.
            DateTime date1 = DateTime.Parse(dateValue);

            Console.WriteLine("Give me another date: ");
            dateValue = Console.ReadLine();
            DateTime date2 = DateTime.Parse(dateValue);

            int aa = 120;
            int bee = 45;
            int difference = aa - bee;
            Dates are related to numbers.

            // Date time calculations, substractions. Overloading minus operator.
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + difference.TotalDays);
            Console.WriteLine("Difference in hours: " + difference.TotalHours);
            */
            // read the dates from the user
            DateTime date1 = ReadDateFromUser("Enter the first date:");
            DateTime date2 = ReadDateFromUser("Enter the second date:");

            // display the values entered
            CultureInfo enUS = new("en-US"); // USA format.
            CultureInfo fr = new("fr"); // French format.

            CultureInfo fiFi = new("fi-FI"); //Finnish format.

            Console.WriteLine("First date (default format): " + date1);
            Console.WriteLine("Second date (default format): " + date2);
            Console.WriteLine("First date (en-US): " + date1.ToString(enUS)); //Convert any value to a string. Passes the parameter enUS.
            Console.WriteLine("First date (en-US): " + date1.ToString(fr));
            Console.WriteLine("First date (fi-FI): " + date1.ToString(fiFi));
            Console.WriteLine("First date (custom): " + date1.ToString("yyyy$MM$dd"));

            int numero = 1234;
            string arvo = numero.ToString(); //Converts the given value to a string.

            // date calculations
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + difference.Days);
            Console.WriteLine("Difference in hours: " + difference.Hours);
            Console.WriteLine("Difference in total days: " + difference.TotalDays); //Shows the difference in actual days.
            Console.WriteLine("Difference in total hours: " + difference.TotalHours); //Shows the difference in actual hours.
        }
        private static DateTime ReadDateFromUser(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string value = Console.ReadLine();
                
                // To check weather the date is correct or not.
                try
                {
                    DateTime date = DateTime.Parse(value);
                    return date;
                }
                catch
                {
                    //  For example 31.13.2021 is not a correct date.

                    Console.WriteLine("The date entered was invalid. Please try again.");
                }
            }
        }
    }
}
