using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string dia;

        
        Console.WriteLine ("Ingrese el dia"); //ingresa el dia de la semana
        dia = Console.ReadLine();

        if (dia == "sabado" || dia == "domingo" ) { //se evalua si es fin de semana
        
        Console.WriteLine ("Es fin de semana"); // muestra si es fin de semana
    } else {
        Console.WriteLine ("no es fin de semana"); // muestra si no es fin de semana
    }
}
}
