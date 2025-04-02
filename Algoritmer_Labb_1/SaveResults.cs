namespace Algoritmer_Labb_1;

public class SaveResults
{
    public static void SaveResultsToCSV(double executionTime, int arrayLength, string algorithmType)
    {
        string filepath = String.Empty;
        
        if (algorithmType == "NumberCounter")
        {
            filepath = "countNumbersExecutionTime.csv";
            using (StreamWriter writer = new StreamWriter(filepath, append: true))
            {
                // Skapar en rad med CSV-headers om filen är tom
                if (new FileInfo(filepath).Length == 0)
                {

                    writer.WriteLine("Number of Elements, Execution Time (ms)");
                }
                
                // Tvungen att byta ut kommatecknet mot punkt så att det fungerar med CSV-filen.
                writer.WriteLine(arrayLength + "," + executionTime.ToString().Replace(",", "."));
                
            }
        }
        else if (algorithmType == "CalculateMaxSumV1" || algorithmType == "CalculateMaxSumV2")
        {
            filepath = "calculateMaxSumExecutionTime.csv";
            using (StreamWriter writer = new StreamWriter(filepath, append: true))
            {
                // Skapar en rad med CSV-headers om filen är tom
                if (new FileInfo(filepath).Length == 0)
                {

                    writer.WriteLine("Number of Elements, Execution Time (ms), Algorithm");
                }
                
                // Tvungen att byta ut kommatecknet mot punkt så att det fungerar med CSV-filen.
                writer.WriteLine($"{arrayLength}, {executionTime.ToString().Replace(",", ".")}, {algorithmType}");
                
            }
        }
        else
        {   
            // Slänger en excption om man försöker spara resultat för en ogiltig algoritm
            throw new ArgumentException(
                $"Saving results for algorithm of type '{algorithmType}' is not supported.");
        }
    }
}