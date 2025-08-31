using aoc2022;

static class Day3
{
    public static async Task Run()
    {
        var ruckSacks = await InputHelper.GetInputForDay(3);
        Part1(ruckSacks);
        Part2(ruckSacks);
    }

    private static void Part1(string[] ruckSacks)
    {
        var answer1 = 0;
        foreach (var sack in ruckSacks)
        {
            var (comp1, comp2) = GetCompartments(sack);
            var map = GetItemMapInCompartment(comp1);

            foreach (var item in comp2)
            {
                if (map.TryGetValue(item, out _))
                {
                    answer1 += GetPriority(item);
                    break;
                }
            }
        }

        Console.WriteLine($"Day 3, part 1: {answer1}");
    }

    private static void Part2(string[] ruckSacks)
    {
        var answer2 = 0;
        var sliceSize = 3;
        for (int i = 0; i < ruckSacks.Length; i += sliceSize)
        {
            var mapA = GetItemMapInCompartment(ruckSacks[i + 1]);
            var mapB = GetItemMapInCompartment(ruckSacks[i + 2]);
            foreach (var item in ruckSacks[i])
            {
                if (mapA.ContainsKey(item) && mapB.ContainsKey(item))
                {
                    answer2 += GetPriority(item);
                    break;
                }
            }
        }
        Console.WriteLine($"Day 3, part 2: {answer2}");
    }

    private static Dictionary<char, int> GetItemMapInCompartment(string comp)
    {
        var itemsInCompartment1 = new Dictionary<char, int>();
        foreach (var item in comp)
        {
            if (itemsInCompartment1.TryGetValue(item, out var itemCount))
            {
                itemsInCompartment1[item] = itemCount + 1;
            }
            else
            {
                itemsInCompartment1[item] = 1;
            }
        }
        return itemsInCompartment1;
    }

    private static int GetPriority(char c)
    {
        var modifier = char.IsUpper(c) ? 38 : 96;
        return c - modifier;
    }

    private static (string comp1, string comp2) GetCompartments(string ruckSack)
    {
        var middle = ruckSack.Length / 2;
        return (ruckSack[..middle], ruckSack[middle..]);
    }
}
