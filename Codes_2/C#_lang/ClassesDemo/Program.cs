using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Customer first = new();
            first.Name = "Moe Moa";
            first.Address = "Tikkakuja 3";
            first.ZipCode = "33400";
            first.City = "Lintula";
            first.Print(); //To print the information of the first customer object.

            Customer second = new();
            second.Name = "Aino Ankka";
            second.Address = "Nokkatie 6";
            second.ZipCode = "33400";
            second.City = "Lintula";
            second.Print(); //To print the information of the second customer object.
            */

            Car auto_1 = new();
            auto_1.Producer = "Toyota";
            auto_1.Model = "RAV4";
            auto_1.isAutomatic = true;
            auto_1.MotorType = "Hybrid";
            auto_1.RegNumber = "ZGU-685";
            auto_1.Speed = 80;
            auto_1.MaxSpeed = 180;
            auto_1.Info();
            auto_1.Drive();
            //auto_1.Brake();
            auto_1.GrowSpeed();
            //auto_1.TellGearType();
            

            Car auto_2 = new();
            auto_2.Producer = "Honda";
            auto_2.Model = "Civic";
            auto_2.isAutomatic = false;
            auto_2.MotorType = "Gasoline";
            auto_2.RegNumber = "BNP-209";
            auto_2.Speed = 120;
            auto_2.MaxSpeed = 180;
            auto_2.Info();
            auto_2.Drive();
            auto_2.Brake();
            //auto_2.TellGearType();
            

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
