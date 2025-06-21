using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of years:");
        int years = int.Parse(Console.ReadLine());
        double FutureValue = Future(years, 1000, 0.05);
        Console.WriteLine($"Future value after {years} years: {FutureValue:C}");
    }

    public static double Future(int years, double currentValue, double growthRate)
    {
        if (years == 0)
            return currentValue;
        return Future(years-1,currentValue * (1 + growthRate), growthRate);
    }
}
