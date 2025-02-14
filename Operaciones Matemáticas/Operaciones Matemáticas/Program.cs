using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir dos números al usuario
        Console.Write("Ingresa el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Realizar operaciones
        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        double division = (double)numero1 / numero2;

        // Mostrar resultados
        Console.WriteLine($"La suma de {numero1} + {numero2} es: {suma}");
        Console.WriteLine($"La resta de {numero1} - {numero2} es: {resta}");
        Console.WriteLine($"La multiplicación de {numero1} * {numero2} es: {multiplicacion}");
        Console.WriteLine($"La división de {numero1} / {numero2} es: {division}");
    }
}
