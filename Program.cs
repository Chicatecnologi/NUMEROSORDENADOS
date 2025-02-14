using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

      
        Console.WriteLine("ingresa los 10 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"numero {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Entrada inválida. Intente de nuevo: ");
            }
        }

        Array.Sort(numeros);

    
        Console.WriteLine("Números ordenados:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

    }
}