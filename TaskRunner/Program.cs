var inputPath = Path.Combine("..", "..", "..", "input", "input02.txt");
var input = File.ReadAllText(inputPath);

Console.WriteLine($"Part 1: {AoC2022.Day02.Part1(input)}");
Console.WriteLine($"Part 2: {AoC2022.Day02.Part2(input)}");