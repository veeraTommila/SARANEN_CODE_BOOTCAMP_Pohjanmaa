using System;

namespace ClassesDemo
{
    class Customer
    {
        //Properties = ominaisuudet (data).
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        //Methods = functionality. Toiminnot.
        public void Print(){
            Console.WriteLine("Customer's name: " + Name);
            Console.WriteLine("Customer's address: " + Address);
            Console.WriteLine("Customer's zipcode: " + ZipCode);
            Console.WriteLine("Customer's city: " + City); 
        }
    }
}