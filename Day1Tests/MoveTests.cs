using AdventOfCode2025;

namespace Day1Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var result = Position.Move(true, 50, 68);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(82, 1)));
    }

    [Test]
    public void Test2()
    {
        var result = Position.Move(true, 82, 30);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(52, 0)));
    }

    [Test]
    public void Test3()
    {
        var result = Position.Move(false, 52, 48);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(0, 1)));
    }

    [Test]
    public void Test4()
    {
        var result = Position.Move(true, 0, 5);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(95, 0)));
    }

    [Test]
    public void Test5()
    {
        var result = Position.Move(false, 95, 60);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(55, 1)));
    }

    [Test]
    public void Test6()
    {
        var result = Position.Move(true, 55, 55);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(0, 1)));
    }

    [Test]
    public void Test7()
    {
        var result = Position.Move(true, 0, 1);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(99, 0)));
    }

    [Test]
    public void Test8()
    {
        var result = Position.Move(true, 99, 99);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(0, 1)));
    }

    [Test]
    public void Test9()
    {
        var result = Position.Move(false, 0, 14);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(14, 0)));
    }

    [Test]
    public void Test10()
    {
        var result = Position.Move(true, 14, 82);

        Assert.That(result, Is.EqualTo(new Tuple<int, int>(32, 1)));
    }
}