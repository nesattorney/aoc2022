var inputPath = Path.Combine("..", "..", "..", "input", "input01.txt");
var input = File.ReadAllText(inputPath);

var result1 = AoC2022.Day01.Part1(input);
var result2 = AoC2022.Day01.Part2(input);

Console.WriteLine($"Part 1: {result1}");
Console.WriteLine($"Part 2: {result2}");