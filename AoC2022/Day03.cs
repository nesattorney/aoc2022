using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022
{
    public class Day03
    {
        public static int Part1(string input)
        {
            var lines = input.Split("\n");

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
            var sum = 0;
            foreach (var item in duplicateItems)
            {
                sum += priorityValues[item];
            }
            return sum;
        }

        public static int Part2(string input)
        {
            throw new NotImplementedException();
        }
    }
}