// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class CASO31
{
    public static void Main(string[] args)
    {
        string producto1 = "celular";
        string producto2 = "reloj";
        string producto3 = "cargador";
        string producto4 = "parlante";
        string producIngre;
        int canti;
        int stock1 = 100;
        int stock2 = 100;
        int stock3 = 100;
        double precioUnit, subtotal;
        Console.WriteLine ("INVENTARIO");
        Console.WriteLine(producto1);
        Console.WriteLine(producto2);
        Console.WriteLine(producto3);
        Console.WriteLine(producto4);
        Console.WriteLine ("Ingrese el nombre del producto: ");
        producIngre = Console.ReadLine();
       bool existe =
    (producIngre == producto1) ||
    (producIngre == producto2) ||
    (producIngre == producto3) ||
    (producIngre == producto4);

Console.WriteLine(existe);

if (!existe)
{
    Environment.Exit(0);
}
        Console.WriteLine ("Ingrese la cantidad: ");
        canti = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Ingrese el precio unitario: ");
        precioUnit = Convert.ToDouble(Console.ReadLine());
        
        subtotal = canti*precioUnit;
        stock1 = (canti <= stock1) ? stock1 - canti : stock1;
        
        Console.WriteLine("--------FACTURA---------");
        Console.WriteLine("producto " + producIngre);
        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("Stock: " + stock1);
    }
}
