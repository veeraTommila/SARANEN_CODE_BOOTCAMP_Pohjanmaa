using System;

namespace ClassesDemo
{
    //Inheritation from the class Car.
    class TruckCar : Car{
        //Added properties.        
        public int NumberOfCars { get; set; }
        public int NumberOfWheels { get; set; }
        
        //Added methods.
        public void InfoMore(){
            Console.WriteLine("Car's producer: " + Producer);
            Console.WriteLine("Car's model: " + Model);
            Console.WriteLine("Number of wheels: " + NumberOfWheels);
            Console.WriteLine("Number of vans: " + NumberOfCars);
            TellGearType();            
            Console.WriteLine("Car's motor type: " + MotorType);
            Console.WriteLine("Car's register number: " + RegNumber);
            Console.WriteLine("The maximum speed: " + MaxSpeed);             
        }

        public void makeSound(){
            System.Console.WriteLine("TÖÖÖT!");
        }

        public void makeReverse(){
            System.Console.WriteLine("Piip, piip, piip!");
        }
  
    }
}