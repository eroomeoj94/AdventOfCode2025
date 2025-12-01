namespace AdventOfCode2025;

public static class Position
{
    public static Tuple<int, int> Move(bool isNegative, int startAt, int increment)
    {
        int output;
        if (isNegative)
        {
            output = startAt - increment;
        }
        else
        {
            output = startAt + increment;
        }

        var howManyTimesPassedZero =
            HowManyTimesPassedZero(startAt, increment, isNegative);

        if (output >= 0 && output <= 99)
            return new Tuple<int, int>(output, howManyTimesPassedZero);

        var mod = output % 100;

        if (mod < 0)
        {
            mod += 100;
        }

        return new Tuple<int, int>(mod, howManyTimesPassedZero);
    }

    public static int HowManyTimesPassedZero(int startAt, int increment, bool isNegative)
    {
        var count = 0;

        // I might of did it with maths but a for loop to increment and
        // count how many times I pass zero seemed like a funny idea
        for (var i = 0; i < increment; i++)
        {
            if (isNegative)
            {
                startAt -= 1;

                if (startAt == 0)
                {
                    count++;
                }

                if (startAt < 0)
                {
                    startAt = 99;
                }
            }
            else
            {
                startAt += 1;

                if (startAt == 100)
                {
                    startAt = 0;
                    count++;
                }
            }
        }
        return count;
    }
}