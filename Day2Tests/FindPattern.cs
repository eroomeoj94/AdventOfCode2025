using Day2;

namespace Day2Tests;

public class FindPatternTests
{
    private readonly Pattern _pattern = new();

    [Test]
    public void Test1()
    {
        var output = _pattern.HasPattern(11);
        Assert.That(output, Is.EqualTo(true));
    }
    [Test]
    public void Test2()
    {
        var output = _pattern.HasPattern(19);
        Assert.That(output, Is.EqualTo(false));
    }
    [Test]
    public void Test3()
    {
        var output = _pattern.HasPattern(22);
        Assert.That(output, Is.EqualTo(true));
    }
}