using System;

namespace ejercicio30
{
  class Moto
  {
    string color;                
    int cilindraje;
    int velocidad;                 
    string marca;                 

    public void mostrar()
{
  Console.WriteLine("Color: " + color);
  Console.WriteLine("cilindraje: " + cilindraje);
  Console.WriteLine("velocidad: " + velocidad);
  Console.WriteLine("marca: " + marca);
  Console.WriteLine();
}

    static void Main(string[] args)
    {
      Moto moto1 = new Moto();
      moto1.color = "verde";
      moto1.cilindraje = 998;
      moto1.velocidad = 250;
      moto1.marca = "Kawasaki";  

      Moto moto2 = new Moto();
      moto2.color = "rojo";
      moto2.cilindraje = 850;
      moto2.velocidad = 300;
      moto2.marca = "Ducati";

      Moto moto3 = new Moto();
      moto3.color = "amarillo";
      moto3.cilindraje = 300;
      moto2.velocidad = 120;
      moto3.marca = "Honda";

      moto1.mostrar();
      moto2.mostrar();
      moto3.mostrar();
      
    }
  }
}
