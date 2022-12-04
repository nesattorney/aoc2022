using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022
{
    public class Day02
    {
        public static int Part1(string input)
        {
            static int HandState(string hand) =>
            hand switch
            {
                "X" => 1,
                "Y" => 2,
                "Z" => 3,
                _ => throw new InvalidDataException("Invalid hand state"),
            };

            static int Outcome(string opponent, string self)
            {
                if (opponent is "A")
                {
                    if (self is "X")
                    {
                        return 3;
                    }
                    if (self is "Y")
                    {
                        return 6;
                    }
                    if (self is "Z")
                    {
                        return 0;
                    }
                }
                if (opponent is "B")
                {
                    if (self is "X")
                    {
                        return 0;
                    }
                    if (self is "Y")
                    {
                        return 3;
                    }
                    if (self is "Z")
                    {
                        return 6;
                    }
                }
                if (opponent is "C")
                {
                    if (self is "X")
                    {
                        return 6;
                    }
                    if (self is "Y")
                    {
                        return 0;
                    }
                    if (self is "Z")
                    {
                        return 3;
                    }
                }
                throw new InvalidDataException("Hand did not match any case");
            }

            var lines = input.Split("\n").Select(x => x.TrimEnd('\r'));
            var score = 0;
            foreach (var line in lines)
            {
                var hands = line.Split(' ');
                if (hands.Count() != 2)
                {
                    throw new InvalidDataException("Input file contains invalid line");
                }
                var opponent = hands[0];
                var self = hands[1];
                score += HandState(self);
                score += Outcome(opponent, self);
            }
            return score;
        }

        public static int Part2(string input)
        {
            int OutcomeScore(string hand) =>
            hand switch
            {
                "X" => 0,
                "Y" => 3,
                "Z" => 6,
                _ => throw new InvalidDataException("Invalid outcome state"),
            };

            int HandScore(string opponent, string outcome)
            {
                var rock = new Dictionary<string, int>
                {
                    {"X", 3 },
                    {"Y", 1},
                    {"Z", 2},
                };
                var paper = new Dictionary<string, int>
                {
                    {"X", 1 },
                    {"Y", 2},
                    {"Z", 3},
                };
                var scissors = new Dictionary<string, int>
                {
                    {"X", 2 },
                    {"Y", 3},
                    {"Z", 1},
                };
                switch (opponent)
                {
                    case "A": return rock[outcome];
                    case "B": return paper[outcome];
                    case "C": return scissors[outcome];
                    default: throw new InvalidDataException("Ïnvalid hand state");
                }
            }

            var lines = input.Split("\n").Select(x => x.TrimEnd('\r'));
            var score = 0;
            foreach (var line in lines)
            {
                var guideInputs = line.Split(' ');
                if (guideInputs.Count() != 2)
                {
                    throw new InvalidDataException("Input file contains invalid line");
                }
                var opponent = guideInputs[0];
                var outcome = guideInputs[1];
                score += OutcomeScore(outcome);
                score += HandScore(opponent, outcome);
            }
            return score;
        }
    }
}