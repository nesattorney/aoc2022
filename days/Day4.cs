using aoc2022;

static class Day4
{
    public static async Task Run()
    {
        var oldLines = await InputHelper.GetInputForDay(4);
        Console.WriteLine($"Day 4, part 1: {oldLines.Length} lines");
        string[] lines = ["2-4,6-8", "2-3,4-5", "5-7,7-9", "2-8,3-7", "6-6,4-6", "2-6,4-8"];
        Part1(lines);
        Part2(lines);
    }

    private static void Part1(string[] lines)
    {
        var answer1 = 0;

        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine($"Day 3, part 1: {answer1}");
    }

    private static void Part2(string[] ruckSacks)
    {
        var answer2 = 0;

        Console.WriteLine($"Day 3, part 2: {answer2}");
    }
}
