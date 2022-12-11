using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022;
public class Day03
{
    private static Dictionary<char, int> getPriorityValues()
    {
        var priority = 1;
        var priorityValues = new Dictionary<char, int>();
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            priorityValues[letter] = priority;
            priority++;
        }
        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
            priorityValues[letter] = priority;
            priority++;
        }
        return priorityValues;
    }

    private static int calculatePriorityValues(IEnumerable<char> items)
    {

        var sum = 0;
        var priorityValues = getPriorityValues();
        foreach (var item in items)
        {
            sum += priorityValues[item];
        }
        return sum;
    }
    public static int Part1(string input)
    {
        var lines = input.Split("\n");
        var duplicateItems = new List<char>();
        foreach (var line in lines)
        {
            var compartmentSize = line.Count() / 2;
            var characterOccurences = new Dictionary<char, bool>();
            for (var i = 0; i < line.Length; i++)
            {
                if (i < compartmentSize)
                {
                    characterOccurences[line[i]] = true;
                }
                else if (characterOccurences.ContainsKey(line[i]))
                {
                    duplicateItems.Add(line[i]);
                    break;
                }
            }
        }
        return calculatePriorityValues(duplicateItems);
    }

    public static int Part2(string input)
    {
        var items = new Dictionary<char, int>();
        var badges = new List<char>();
        var lineCount = 0;
        //todo: currently counts occurenses across every 3 lines. make it look for occurences on 3 consecutive lines
        foreach (var item in input)
        {
            switch (item)
            {
                case '\r':
                    continue;
                case '\n':
                    lineCount = (lineCount + 1) % 3;
                    if (lineCount == 0) items = new Dictionary<char, int>();
                    continue;
            }
            int itemCount;
            if (!items.TryGetValue(item, out itemCount) && lineCount % 3 == 0)
            {
                items[item] = 1;
                continue;
            }
            if (itemCount == lineCount)
            {
                itemCount++;
                items[item] = itemCount;
                if (itemCount == 3) badges.Add(item);
            }
        }
        return calculatePriorityValues(badges);
    }
}