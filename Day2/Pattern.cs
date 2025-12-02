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
        
        for (int i = 1; i < stringValLength; i++)
        {
            var splits = Split(stringVal, i).ToList();
            
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
    
    private static IEnumerable<string> Split(string str, int chunkSize)
    {
        return Enumerable.Range(0, str.Length / chunkSize)
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