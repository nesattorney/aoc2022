using aoc2022;

static class Day2
{
    public static async Task Run()
    {
        var input = await InputHelper.GetInputForDay(2);

        var scores = new Dictionary<string, int>
        {
            { "A X", 3 + 1 },
            { "B X", 0 + 1 },
            { "C X", 6 + 1 },
            { "A Y", 6 + 2 },
            { "B Y", 3 + 2 },
            { "C Y", 0 + 2 },
            { "A Z", 0 + 3 },
            { "B Z", 6 + 3 },
            { "C Z", 3 + 3 },
        };

        var answer1 = 0;
        foreach (var line in input)
        {
            if (line.Length == 0)
                break;
            answer1 += scores[line];
        }

        Console.WriteLine($"Day 2, part 1: {answer1}");

        var answer2 = 0;
        var scores2 = new Dictionary<string, int>
        {
            { "A X", 0 + 3 },
            { "B X", 0 + 1 },
            { "C X", 0 + 2 },
            { "A Y", 3 + 1 },
            { "B Y", 3 + 2 },
            { "C Y", 3 + 3 },
            { "A Z", 6 + 2 },
            { "B Z", 6 + 3 },
            { "C Z", 6 + 1 },
        };
        foreach (var line in input)
        {
            if (line.Length == 0)
                break;
            answer2 += scores2[line];
        }
        Console.WriteLine($"Day 2, part 2: {answer2}");
    }
}
