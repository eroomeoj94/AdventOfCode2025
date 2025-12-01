using AdventOfCode2025;

try
{
    var position = 50;
    var passedZero = 0;

    var sr = new StreamReader("Input.txt");
    var line = sr.ReadLine();
    
    while (line != null)
    {
        Console.WriteLine(line);
        var negative = line.StartsWith("L");
        var turn = int.Parse(line.Remove(0, 1));
        Console.WriteLine("Start at " + position);

        var (item1,item2) = Position.Move(negative, position, turn);

        position = item1;
        
        passedZero += item2;

        Console.WriteLine($"Move to {(negative ? "left" : "right")} by {position}");

        line = sr.ReadLine();
    }

    Console.WriteLine("Final position: " + position);
    Console.WriteLine("Passed zero: " + passedZero);
    sr.Close();
    Console.ReadLine();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}