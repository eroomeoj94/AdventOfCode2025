namespace Day2;

public class Pattern
{
    public static List<long> FindPatterns(long minNumber, long maxNumber)
    {
        var range = CreateRange(minNumber, maxNumber - minNumber + 1);
        return range.Where(HasPattern).ToList();
    }
    
    public static bool HasPattern(long number)
    {
        var stringVal = number.ToString();
        var stringValLength = stringVal.Length;
        
        // Loop through all possible splits
        for (int i = 1; i < stringValLength; i++)
        {
            // Create sub strings of those splits
            var splits = Split(stringVal, i).ToList();
            
            // If there is only one split then we can't have a pattern
            if(!(splits.Count > 1))
                continue;
            
            // Split doesn't give you full splits so need to check
            if(splits.Select(x => x.Length).Sum() != stringValLength)
                continue;
            
            // If all items are the same then we have a pattern
            var allAreSame = splits.All(x => x == splits.First());

            if (!allAreSame) 
                continue;
            
            Console.WriteLine(number + " has pattern " + string.Join(',',splits));
            return true;
        }
        
        return false;
    }
    
    /// <summary>
    /// Splits a string into chunks of a given size e.g. "123456789" into "123", "456", "789" if chunk size is 3
    /// FYI it cuts off the last chunk if it's not a full chunk.
    /// </summary>
    /// <param name="str">The string to split</param>
    /// <param name="chunkSize"></param>
    /// <returns>An array of splitted up strings</returns>
    private static IEnumerable<string> Split(string str, int chunkSize)
    {
        return Enumerable
            .Range(0, str.Length / chunkSize)
            .Select(i => str.Substring(i * chunkSize, chunkSize));
    }
    
    private static IEnumerable<long> CreateRange(long start, long count)
    {
        var limit = start + count;

        while (start < limit)
        {
            yield return start;
            start++;
        }
    }
}