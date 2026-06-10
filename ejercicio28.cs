using System;

public class ejercicio1
{
 
        class Car {
            string color;
            int maxSpeed;
            
            static void Main(string[] args) {
                Car myObj = new Car();
                myObj.color = "verde"; 
                myObj.maxSpeed = 400; 
                Console.WriteLine("color es: " + myObj.color);
                Console.WriteLine("velocidad: " + myObj.maxSpeed);
                
            
        }
    }
}
