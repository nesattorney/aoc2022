using aoc2022;

static class Day1
{
    public static async Task Run()
    {
        var input = await InputHelper.GetInputForDay(1);

        var sums = new Dictionary<int, int>();
        var currentElf = 0;

        foreach (var line in input)
        {
            if (line.Length == 0)
            {
                currentElf++;
                continue;
            }
            var exists = sums.TryGetValue(currentElf, out var currentSum);
            sums[currentElf] = exists ? currentSum + int.Parse(line) : int.Parse(line);
        }

        var answer1 = sums.MaxBy(x => x.Value);
        Console.WriteLine($"Day 1, part 1: {answer1.Value}");

        var answer2 = sums.OrderByDescending(x => x.Value).Take(3).Sum(x => x.Value);
        Console.WriteLine($"Day 1, part 2: {answer2}");
    }
}
