using System;

namespace ClassesDemo
{
    class Car{
        //Data = properties. The car objects can have these.
        public string Producer { get; set; } //Get reads a value and Set writes the value to the variable.
        public string Model { get; set; }
        public bool isAutomatic { get; set; }
        public string MotorType { get; set; }
        public int Speed { get; set; }   
        public int MaxSpeed { get; set; }     
        public string RegNumber { get; set; }
        
        //Methods = functionalities. The car objects can do these.
        public void TellGearType(){
            if(isAutomatic == true){
                Console.WriteLine("The car is automatic.");                
            }
            if(isAutomatic == false)
            {
                Console.WriteLine("The car is manual.");
            }
        }
    
        public void Info(){
            Console.WriteLine("Car's producer: " + Producer);
            Console.WriteLine("Car's model: " + Model);
            TellGearType();            
            Console.WriteLine("Car's motor type: " + MotorType);
            Console.WriteLine("Car's register number: " + RegNumber);
            Console.WriteLine("The maximum speed: " + MaxSpeed);             
        }

        public void Drive(){
            System.Console.WriteLine("You drive home in " + Speed + "km/h.");
        }

        public void GrowSpeed(){
            if(Speed < 100){
                //Grows the car's speed to 100 km/h.
                for(Speed = 0; Speed < 100; Speed++){}
            }
            System.Console.WriteLine("Your speed is now: " + Speed + "km/h. \n");
        }

        public void Brake(){
            Speed -= 20;
            System.Console.WriteLine("Break! Your speed is now: " + Speed + "km/h. \n");
            /*
            Speed -= 20;
            if(Speed < 0){
                Speed = 0;
            }
            */
        }

        
    }    
}