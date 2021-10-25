using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer first = new();
            first.Name = "Moe Moa";
            first.Address = "Tikkakuja 3";
            first.ZipCode = "33400";
            first.City = "Lintula";
            first.Print();

            Customer second = new();
            second.Name = "Aino Ankka";
            second.Address = "Nokkatie 6";
            second.ZipCode = "33400";
            second.City = "Lintula";
            second.Print();


            /*
            string customerName = "Allu Asiakas";
            string customerAddress = "Vattuniemenkatu 13 B 20";
            string customerZipCode = "00210";
            string customerCity = "Helsinki";

            PrintCustomer(customerName,customerAddress,customerZipCode,customerCity);

            string customerName2 = "Moe Mooa";
            string customerAddress2 = "Vattuniemenkuja 3 A 14";
            string customerZipCode2 = "00210";
            string customerCity2 = "Helsinki";

            PrintCustomer(customerName2,customerAddress2,customerZipCode2,customerCity2);
            */ 
        }

        /*private static void PrintCustomer(string customerName, string customerAddress, string customerZipCode, string customerCity)
        {
            //throw new NotImplementedException();
            Console.WriteLine(customerName);
            Console.WriteLine(customerAddress);
            Console.WriteLine(customerZipCode);
            Console.WriteLine(customerCity);    
                  
        }*/
    }
}
