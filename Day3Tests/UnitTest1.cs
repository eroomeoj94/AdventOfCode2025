using Day3;

namespace Day3Tests;

public class Tests
{
    private readonly Battery _battery = new();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var maxVoltage = _battery.GetMaxVoltage("987654321111111");
        Assert.That(maxVoltage, Is.EqualTo(98));
    }
    
    [Test]
    public void Test2()
    {
        var maxVoltage = _battery.GetMaxVoltage("811111111111119");
        Assert.That(maxVoltage, Is.EqualTo(89));
    }
    
    [Test]
    public void Test3()
    {
        var maxVoltage = _battery.GetMaxVoltage("234234234234278");
        Assert.That(maxVoltage, Is.EqualTo(78));
    }
    
    [Test]
    public void Test4()
    {
        var maxVoltage = _battery.GetMaxVoltage("818181911112111");
        Assert.That(maxVoltage, Is.EqualTo(92));
    }
}