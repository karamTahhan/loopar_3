using System;

class Program
{
    static void Main()
    {
        int totalSum = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ange heltal {i}: ");
            int number = int.Parse(Console.ReadLine());
            totalSum += number;
        }

        Console.WriteLine($"Summan av de inmatade talen är: {totalSum}");
    }
}