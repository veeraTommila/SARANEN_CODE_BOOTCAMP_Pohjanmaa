using System;

namespace ClassesDemo
{
    class Car{
        //Data = properties.
        public string Producer { get; set; }
        public string Model { get; set; }
        public string GearType { get; set; }
        public string MotorType { get; set; }
        public int Speed { get; set; }   
        public int MaxSpeed { get; set; }     
        public string RegNumber { get; set; }
        

        public void Info(){
            Console.WriteLine("Car's producer: " + Producer);
            Console.WriteLine("Car's model: " + Model);
            Console.WriteLine("Car's gear type: " + GearType);
            Console.WriteLine("Car's motor type: " + MotorType);
            Console.WriteLine("Car's register number: " + RegNumber);
            Console.WriteLine("The maximum speed: " + MaxSpeed);
            //Console.WriteLine("Car's speed: " + Speed); 
        }

        public void Drive(){
            System.Console.WriteLine("You drive home in " + Speed + "km/h.");
        }

        public void Break(){
            Speed = Speed-20;
            System.Console.WriteLine("Break! Your speed is now: " + Speed + "km/h. \n");
        }
    }    
}