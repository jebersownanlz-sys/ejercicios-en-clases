using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string licencia;
        int anosEx;
        
        Console.WriteLine ("Tiene experiencia (si/no)");//ingresa si tiene experiencia
        licencia = Console.ReadLine();
        Console.WriteLine ("Ingrese años de experiencia"); //ingresa los años de experiencia
        anosEx = Convert.ToInt32(Console.ReadLine());
        
        if (licencia == "si" && anosEx >=2) { //se evalua si tiene licencia y los años de experiencia son mas de dos
            Console.WriteLine ("Estas aceptado"); //muestra que fue aceptado
        }
        
        
    }
}
