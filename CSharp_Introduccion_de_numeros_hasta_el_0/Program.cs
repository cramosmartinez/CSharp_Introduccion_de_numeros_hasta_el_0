using System;
using System.Collections.Generic;

class NumberAnalyzer
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.Write("Ingrese un número (0 para terminar): ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        if (numbers.Count > 0)
        {
            int max = MaxNumber(numbers);
            int min = MinNumber(numbers);
            int difference = max - min;

            Console.WriteLine($"Número más alto: {max}");
            Console.WriteLine($"Número más bajo: {min}");
            Console.WriteLine($"Diferencia entre el mayor y el menor: {difference}");
            Console.WriteLine($"Cantidad de números introducidos: {numbers.Count}");
        }
        else
        {
            Console.WriteLine("No se introdujeron números.");
        }
    }

    static int MaxNumber(List<int> numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static int MinNumber(List<int> numbers)
    {
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }
}
