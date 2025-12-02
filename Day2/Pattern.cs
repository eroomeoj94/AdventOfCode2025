namespace Day2;

public class Pattern
{
    public List<long> FindPatterns(long minNumber, long maxNumber)
    {
        var range = CreateRange(minNumber, maxNumber - minNumber + 1);
        return range.Where(HasPattern).ToList();
    }
    
    public bool HasPattern(long number)
    {
        var stringVal = number.ToString();

        if (stringVal.Length % 2 != 0)
        {
            // Console.WriteLine("Odd length: " + number);
            return false;
        }

        var firstHalf = stringVal.Substring(0, stringVal.Length / 2);
        var secondHalf = stringVal.Substring(stringVal.Length / 2);

        // Console.WriteLine(number + " " + firstHalf + " " + secondHalf);
        return firstHalf == secondHalf;
    }
    
    private IEnumerable<long> CreateRange(long start, long count)
    {
        var limit = start + count;

        while (start < limit)
        {
            yield return start;
            start++;
        }
    }
}