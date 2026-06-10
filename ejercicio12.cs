//para poder sacar la raiz cubica debemos utilizar el metodo Math.Cbrt
using System;

namespace ejercicio12   
{
  class Program
  {
    static void Main(string[] args)
    {

        double numero = 27.0;
        double resultado = Math.Cbrt(numero);
      Console.WriteLine($"La raiz cubica de {numero} es: {resultado}");
     }
  }
}
