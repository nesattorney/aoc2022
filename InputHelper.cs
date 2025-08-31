using Microsoft.Extensions.Configuration;

namespace aoc2022;

public static class InputHelper
{
    public static async Task<string[]> GetInputForDay(int day)
    {
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        var sessionCookie = config["session"];
        var url = $"https://adventofcode.com/2022/day/{day}/input";
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Cookie", $"session={sessionCookie}");
        var response = await httpClient.GetStringAsync(url);
        var lines = response.Split('\n');
        var lineCount = lines.Length - 1;
        return lines[..lineCount];
    }
}
