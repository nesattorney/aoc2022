namespace AoC2022Tests;

[TestFixture]
public class Tests
{
    string _input01;
    [SetUp]
    public void Setup()
    {
        _input01 = File.ReadAllText(Path.Combine("..", "..", "..", "input", "example01.txt"));
    }

    [Test]
    public void Day01_Part1()
    {
        Assert.That(() => AoC2022.Day01.Part1(_input01), Is.EqualTo(24000));
    }

    [Test]
    public void Day01_Part2()
    {
        Assert.That(() => AoC2022.Day01.Part2(_input01), Is.EqualTo(45000));
    }
}