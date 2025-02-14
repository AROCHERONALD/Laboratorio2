using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaración de variables
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        // Solicitar valores al usuario
        Console.Write("Ingresa un número entero: ");
        numeroEntero = int.Parse(Console.ReadLine());

        Console.Write("Ingresa un número decimal: ");
        numeroDecimal = double.Parse(Console.ReadLine());

        Console.Write("Ingresa un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingresa un valor verdadero o falso (true/false): ");
        valorBooleano = bool.Parse(Console.ReadLine());

        // Mostrar los valores
        Console.WriteLine($"Número Entero: {numeroEntero}");
        Console.WriteLine($"Número Decimal: {numeroDecimal}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Valor Booleano: {valorBooleano}");
    }
}

