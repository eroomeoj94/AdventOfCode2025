namespace Day3;

public class BatteryPartOne
{
    public int GetMaxVoltage(string input)
    {
        var length = input.Length;
        var biggestNumber = 0;

        for (var i = 0; i < length -1; i++)
        {
            for (var j = 1; j < length; j++)
            {
                // Skip the same number
                if(i == j)
                    continue;

                // Can't have i bigger than j
                if (i > j)
                    continue;
                
                var currentNumber = GetCurrentNumber(input[i],input[j]);
                
                if(currentNumber > biggestNumber)
                    biggestNumber = currentNumber;
            }
        }
        
        return biggestNumber;
    }

    private static int GetCurrentNumber(char c, char c1)
    {
        var combined = Convert.ToInt32(c + c1.ToString());
        return combined;
    }
}