using System;

class Program
{
    // Recursive method to calculate sum from n to m
    static int RecursiveSum(int n, int m)
    {
        if (n > m) return 0;
        return n + RecursiveSum(n + 1, m);
    }

    // Recursive method to count how many times a number can be divided by 2 evenly
    static int CountDivisionsBy2(int number)
    {
        if (number % 2 != 0 || number == 0)
            return 0;
        return 1 + CountDivisionsBy2(number / 2);
    }

    static void Main()
    {
        // Addition section
        Console.WriteLine("Addition");
        Console.Write("Enter number n:\n");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number m:\n");
        int m = int.Parse(Console.ReadLine());

        int sum = RecursiveSum(n, m);
        Console.WriteLine(sum);

        // Division section
        Console.WriteLine("Division");
        Console.Write("Enter your number:\n");
        int number = int.Parse(Console.ReadLine());

        int count = CountDivisionsBy2(number);
        Console.WriteLine($"Total number of divisions: {count}");
    }
}
