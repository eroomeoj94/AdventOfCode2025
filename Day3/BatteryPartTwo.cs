namespace Day3;

public class BatteryPartTwo
{
    public long GetMaxVoltage(string input)
    {
        var values = MaxSubsequence(input);
        return long.Parse(values);
    }
    private string MaxSubsequence(string digits)
    {
        var n = digits.Length;
        const int sequenceLength = 12;
        
        var result = new char[sequenceLength];
        var indexInResult = 0;   
        var start = 0; 

        // While we have not reached the end of the sequence
        while (indexInResult < sequenceLength)
        {
            var end = n - (sequenceLength - indexInResult); 
            var maxDigit = '0';
            var maxPos = start;

            // Loop through the rest of the strings
            for (var i = start; i <= end; i++)
            {
                if (digits[i] <= maxDigit) 
                    continue;
                
                maxDigit = digits[i];
                maxPos = i;
                
                // If we find a 9 stop looping.
                if (maxDigit == '9') 
                    break;
            }

            result[indexInResult++] = maxDigit;
            
            // Have to move the start to the last selected position;
            start = maxPos + 1;
        }

        return new string(result);
    }
}