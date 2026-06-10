using System;

namespace ejercicio29
{
  class Car
  {
    string color;                
    int maxSpeed;
    string marca;                 
    public void fullThrottle()   
    {
      Console.WriteLine("The car is going as fast as it can!");
    }

    public void mostrar()
{
  Console.WriteLine("Color: " + color);
  Console.WriteLine("Velocidad maxima: " + maxSpeed);
  Console.WriteLine("Marca: " + marca);
  Console.WriteLine();
}

    static void Main(string[] args)
    {
      Car carro1 = new Car();
      carro1.color = "rojo";
      carro1.maxSpeed = 200;
      carro1.marca = "tesla";  

      Car carro2 = new Car();
      carro2.color = "verde";
      carro2.maxSpeed = 100;
      carro2.marca = "BMW";

      Car carro3 = new Car();
      carro3.color = "amarillo";
      carro3.maxSpeed = 300;
      carro3.marca = "Audi";

      carro1.mostrar();
      carro2.mostrar();
      carro3.mostrar();
      
    }
  }
}
