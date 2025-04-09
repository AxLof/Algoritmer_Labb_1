using System.Diagnostics;

namespace Algoritmer_Labb_1;

public class NumberCounter
{
    
    private static (int, double) FindDuplicates(int[] arr, int targetNumber)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], 1);
            }
            else
            {
                dict[arr[i]] += 1;
            }
        }
        stopwatch.Stop();
        
        return (dict[targetNumber], stopwatch.Elapsed.TotalMilliseconds);
    }
    public static void TestFindDuplicates(int targetNumber, int arrayLength)
    {
        // Skapar array med slumpmässiga siffror 0-9
        int[] randomNumbers = NumberGenerator.GenerateRandomNumbers(arrayLength, 0, 9);
        (int count, double time) = FindDuplicates(randomNumbers, targetNumber);
        
        Console.WriteLine($"Count: {count}");
        Console.WriteLine($"Time of executing the NumberCounter algorithm with an array of length {arrayLength}: {time} ms\n");
        SaveResults.SaveResultsToCSV(time, arrayLength, "NumberCounter");
    }
    
}