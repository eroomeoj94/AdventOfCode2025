
using Day3;

var sr = new StreamReader("Input.txt");
var battery = new Battery();
var total = 0;
var line = sr.ReadLine();
    
while (line != null)
{
    Console.WriteLine(line);

    var current = battery.GetMaxVoltage(line);
    
    total += current;
    
    line = sr.ReadLine();
}

Console.WriteLine("Total Voltage: " + total);
sr.Close();
Console.ReadLine();