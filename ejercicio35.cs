using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int day;

        Console.WriteLine("Ingrese un numero del 1 al 7:");
        day = Convert.ToInt32(Console.ReadLine());

        switch(day)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;

            case 2:
                Console.WriteLine("Martes");
                break;

            case 3:
                Console.WriteLine("Miercoles");
                break;

            case 4:
                Console.WriteLine("Jueves");
                break;

            case 5:
                Console.WriteLine("Viernes");
                break;

            default:
                Console.WriteLine("Fin de semana");
                break;
        }
    }
}
