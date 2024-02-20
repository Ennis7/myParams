using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many random numbers would you like to generate?");
        int size = int.Parse(Console.ReadLine());
        int[] collection = new int[size];

        Random r = new Random();
        for (int i = 0; i < size; i++)
        {
            collection[i] = r.Next(1, 10);
            Console.WriteLine(collection[i]);
        }
        Console.WriteLine($"Total of the numbers array={Add(collection)}");
   
        Console.WriteLine($"Total of the numbers array={Multi(collection)}");
        Console.ReadKey();
    }
    //add array
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    //multiple array
    static int Multi(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}

