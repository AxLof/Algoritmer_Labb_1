namespace Algoritmer_Labb_1;

public class NumberGenerator
{
    public static int[] GenerateRandomNumbers(int length, int startRange, int endRange)
    {
        int[] newArray = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            newArray[i] = random.Next(startRange, endRange+1);
        }

        return newArray;
    }
    
    //Array.ForEach(GenerateRandomNumbers(5), Console.WriteLine);
}