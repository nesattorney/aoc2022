namespace AoC2022Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void Day01_Part1()
    {
        var input01 = File.ReadAllText(Path.Combine("..", "..", "..", "input", "ex01.txt"));
        Assert.That(() => AoC2022.Day01.Part1(input01), Is.EqualTo(24000));
    }

    [Test]
    public void Day01_Part2()
    {
        var input01 = File.ReadAllText(Path.Combine("..", "..", "..", "input", "ex01.txt"));
        Assert.That(() => AoC2022.Day01.Part2(input01), Is.EqualTo(45000));
    }

    [Test]
    public void Day02_Part1()
    {
        var input01 = File.ReadAllText(Path.Combine("..", "..", "..", "input", "ex02.txt"));
        Assert.That(() => AoC2022.Day02.Part1(input01), Is.EqualTo(15));
    }

    [Test]
    public void Day02_Part2()
    {
        var input01 = File.ReadAllText(Path.Combine("..", "..", "..", "input", "ex02.txt"));
        Assert.That(() => AoC2022.Day02.Part2(input01), Is.EqualTo(12));
    }

    [Test]
    public void Day03_Part1()
    {
        var input01 = File.ReadAllText(Path.Combine("..", "..", "..", "input", "ex03.txt"));
        Assert.That(() => AoC2022.Day03.Part1(input01), Is.EqualTo(157));
    }
}