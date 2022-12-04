namespace AoC2022
{
    public class Day01
    {
        public static int Part1(string input)
        {
            var lines = input.Split("\n");

            int topSum = 0;
            int currentSum = 0;
            for (var i = 0; i < lines.Count(); i++)
            {
                if (lines[i] == "\r")
                {
                    currentSum = 0;
                    continue;
                }
                currentSum += int.Parse(lines[i]);
                if (currentSum > topSum)
                {
                    topSum = currentSum;
                }
            }

            return topSum;
        }

        public static int Part2(string input)
        {
            var lines = input.Split("\n");
            int currentSum = 0;
            var sumHistory = new List<int>();
            for (var i = 0; i < lines.Count(); i++)
            {
                if (lines[i] == "\r")
                {
                    sumHistory.Add(currentSum);
                    currentSum = 0;
                    continue;
                }
                currentSum += int.Parse(lines[i]);
            }
            sumHistory.Add(currentSum);

            sumHistory.Sort();
            return sumHistory.TakeLast(3).Sum();
        }
    }
}