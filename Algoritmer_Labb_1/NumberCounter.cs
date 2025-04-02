using System.Diagnostics;

namespace Algoritmer_Labb_1;

public class NumberCounter
{
    private static int CountNumber(int[] numbers, int targetNumber)
    {
        int count = 0;

        foreach (int number in numbers)
        {
            if (number == targetNumber)
            {
                count++;
            }
        }

        return count;
    }

    public static void TestCountNumber(int targetNumber, int arrayLength)
    {
        // Skapar array med slumpmässiga siffror 0-9
        int[] randomNumbers = NumberGenerator.GenerateRandomNumbers(arrayLength, 0, 9);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int count = CountNumber(randomNumbers, targetNumber);
        stopwatch.Stop();
        
        Console.WriteLine($"Count: {count}");
        Console.WriteLine($"Time of executing the NumberCounter algorithm with an array of length {arrayLength}: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
        SaveResults.SaveResultsToCSV(stopwatch.Elapsed.TotalMilliseconds, arrayLength, "NumberCounter");
    }
}