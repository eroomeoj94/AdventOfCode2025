using Day3;

namespace Day3Tests;

public class Part2Tests
{
    private readonly BatteryPartTwo _batteryPartTwo = new();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var maxVoltage = _batteryPartTwo.GetMaxVoltage("987654321111111");
        Assert.That(maxVoltage, Is.EqualTo(987654321111));
    }
    
    [Test]
    public void Test2()
    {
        var maxVoltage = _batteryPartTwo.GetMaxVoltage("811111111111119");
        Assert.That(maxVoltage, Is.EqualTo(811111111119));
    }
    
    [Test]
    public void Test3()
    {
        var maxVoltage = _batteryPartTwo.GetMaxVoltage("234234234234278");
        Assert.That(maxVoltage, Is.EqualTo(434234234278));
    }
    
    [Test]
    public void Test4()
    {
        var maxVoltage = _batteryPartTwo.GetMaxVoltage("818181911112111");
        Assert.That(maxVoltage, Is.EqualTo(888911112111));
    }
}