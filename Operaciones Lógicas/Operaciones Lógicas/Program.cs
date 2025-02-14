using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir dos números
        Console.Write("Ingresa el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Comparaciones
        Console.WriteLine($"{numero1} es mayor que {numero2}: {numero1 > numero2}");
        Console.WriteLine($"{numero1} es menor que {numero2}: {numero1 < numero2}");
        Console.WriteLine($"{numero1} es igual a {numero2}: {numero1 == numero2}");

        // Operadores lógicos
        bool resultadoAnd = (numero1 > 10) && (numero2 < 20);
        bool resultadoOr = (numero1 < 5) || (numero2 > 10);

        Console.WriteLine($"Resultado de AND: {resultadoAnd}");
        Console.WriteLine($"Resultado de OR: {resultadoOr}");
    }
}

