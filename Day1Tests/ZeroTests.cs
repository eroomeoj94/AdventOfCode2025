using AdventOfCode2025;

namespace Day1Tests;

public class ZeroTests
{
    [Test]
    public void Test1()
    {
        var result = Position.HowManyTimesPassedZero(50, 68,  false);

        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Test2()
    {
        var result = Position.HowManyTimesPassedZero(50, 40, true);

        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Test3()
    {
        var result = Position.HowManyTimesPassedZero(50, 1000, false);

        Assert.That(result, Is.EqualTo(10));
    }
    
    [Test]
    public void Test5()
    {
        var result = Position.HowManyTimesPassedZero(50, 50, false);

        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Test6()
    {
        var result = Position.HowManyTimesPassedZero(50, 50, true);

        Assert.That(result, Is.EqualTo(1));
    }
}