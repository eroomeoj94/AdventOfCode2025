using Day2;

namespace Day2Tests;

public class FindPatternTests
{
    private readonly Pattern _pattern = new();

    [Test]
    public void Test1()
    {
        var output = Pattern.HasPattern(11);
        Assert.That(output, Is.EqualTo(true));
    }
    [Test]
    public void Test2()
    {
        var output = Pattern.HasPattern(19);
        Assert.That(output, Is.EqualTo(false));
    }
    [Test]
    public void Test3()
    {
        var output = Pattern.HasPattern(22);
        Assert.That(output, Is.EqualTo(true));
    }
    
    [Test]
    public void Test4()
    {
        var output = Pattern.HasPattern(12341234);
        Assert.That(output, Is.EqualTo(true));
    }
    
    [Test]
    public void Test5()
    {
        var output = Pattern.HasPattern(123123123);
        Assert.That(output, Is.EqualTo(true));
    }
    
    [Test]
    public void Test6()
    {
        var output = Pattern.HasPattern(1212121212);
        Assert.That(output, Is.EqualTo(true));
    }
    
    [Test]
    public void Test7()
    {
        var output = Pattern.HasPattern(1111111);
        Assert.That(output, Is.EqualTo(true));
    }
}