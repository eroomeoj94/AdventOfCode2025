using Day2;

namespace Day2Tests;

public class FindPatternsTests
{
    private readonly Pattern _pattern = new();

    [Test]
    public void Test1()
    {
        var patterns = _pattern.FindPatterns(11, 22);
        Assert.That(patterns, Is.EqualTo(new List<int> {11, 22}));
    }
    
    [Test]
    public void Test2()
    {
        var patterns = _pattern.FindPatterns(95, 115);
        Assert.That(patterns, Is.EqualTo(new List<int> {99}));
    }
    
    [Test]
    public void Test3()
    {
        var patterns = _pattern.FindPatterns(998,1012);
        Assert.That(patterns, Is.EqualTo(new List<int> {1010}));
    }
    
    [Test]
    public void Test4()
    {
        var patterns = _pattern.FindPatterns(1188511880, 1188511890);
        Assert.That(patterns, Is.EqualTo(new List<int> {1188511885}));
    }
    
    [Test]
    public void Test5()
    {
        var patterns = _pattern.FindPatterns(222220, 222224);
        Assert.That(patterns, Is.EqualTo(new List<int> {222222}));
    }
    
    [Test]
    public void Test6()
    {
        var patterns = _pattern.FindPatterns(1698522, 1698528);
        Assert.That(patterns, Is.EqualTo(new List<int> {}));
    }
    [Test]
    public void Test7()
    {
        var patterns = _pattern.FindPatterns(446443, 446449);
        Assert.That(patterns, Is.EqualTo(new List<int> {446446}));
    }
    [Test]
    public void Test8()
    {
        var patterns = _pattern.FindPatterns(38593856, 38593862);
        Assert.That(patterns, Is.EqualTo(new List<int> {38593859}));
    }
    
    [Test]
    public void Test10()
    {
        var patterns = _pattern.FindPatterns(565653, 565659);
        Assert.That(patterns, Is.EqualTo(new List<int> {}));
    }
    
    [Test]
    public void Test11()
    {
        var patterns = _pattern.FindPatterns(824824821, 824824827);
        Assert.That(patterns, Is.EqualTo(new List<int> {}));
    }
    
    [Test]
    public void Test12()
    {
        var patterns = _pattern.FindPatterns(2121212118, 2121212124);
        Assert.That(patterns, Is.EqualTo(new List<int> {}));
    }
}