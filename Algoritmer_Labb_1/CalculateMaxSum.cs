using System.Diagnostics;

namespace Algoritmer_Labb_1;

public class CalculateMaxSum
{
    private static int MaxSumAlgorithmV1(int[] numbers)
    {
        // Sätter base value till lägsta resp. högsta möjliga
        int largestSum = 0;
        
        // Nestlad for loop för att testa alla kombinationer
        foreach (int firstNumber in numbers)
        {
            foreach (int secondNumber in numbers)
            {
                if (largestSum < firstNumber - secondNumber)
                {
                    largestSum = int.Abs(firstNumber - secondNumber);
                }
            }
        }

        return largestSum;
    }

    private static int MaxSumAlgorithmV2(int[] numbers)
    {
        // Sätter default värde till det "sämsta möjliga"
        int maxInteger = Int32.MinValue;
        int minInteger = Int32.MaxValue;
        
        foreach (int number in numbers)
        {
            if (number > maxInteger)
            {
                maxInteger = number;
            }
            if (number < minInteger)
            {
                minInteger = number;
            }
        }
        
        /* Största skillnaden får vi alltid genom att beräkna "största - minsta" talet.
           (eller "minsta - största" talet, absolutbeloppet blir detsamma) */
        return maxInteger - minInteger;
    }
    
    public static void TestMaxSumAlgorithmV1(long arrayLength)
    {
        // Skapar array med slumpmässiga siffror -100-100
        int[] randomNumbers = NumberGenerator.GenerateRandomNumbers(arrayLength, -100, 100);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int sum = MaxSumAlgorithmV1(randomNumbers);
        stopwatch.Stop();
    
        Console.WriteLine($"The max sum of integers in the array was {sum}");
        Console.WriteLine($"Time of executing this function with an array of length {arrayLength}: {stopwatch.ElapsedMilliseconds} ms");
        SaveResults.SaveResultsToCSV(stopwatch.ElapsedMilliseconds, arrayLength, "CalculateMaxSumV1");
    }
    
    public static void TestMaxSumAlgorithmV2(long arrayLength)
    {
        // Skapar array med slumpmässiga siffror -100 - 100
        int[] randomNumbers = NumberGenerator.GenerateRandomNumbers(arrayLength, -100, 100);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int sum = MaxSumAlgorithmV2(randomNumbers);
        stopwatch.Stop();
    
        Console.WriteLine($"The max sum of integers in the array was {sum}");
        Console.WriteLine($"Time of executing this function with an array of length {arrayLength}: {stopwatch.ElapsedMilliseconds} ms");
        SaveResults.SaveResultsToCSV(stopwatch.ElapsedMilliseconds, arrayLength, "CalculateMaxSumV2");
    }
}