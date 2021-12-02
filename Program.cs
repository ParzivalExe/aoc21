using aoc.structure;
using aoc21.day1;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace aoc.twentyOne
{

    public class Program
    {

        public static List<Day> Days = new List<Day>()
        {
            new Day1()
        };

        public static void Main(string[] args)
        {
            if(args.Length >= 1 && args.Length <= 2)
            {
                int dayNumber = -1;
                if(int.TryParse(args[0], out dayNumber))
                {
                    Day day = Days[dayNumber - 1];

                    string path = args.Length >= 2 ? args[1] : day.DefaultPath;

                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    string computeResult = day.ComputeDay(path);

                    stopwatch.Stop();

                    if(computeResult == null)
                    {
                        Console.WriteLine($"Compute of Day {dayNumber} with InputeFile {path} has resulted in internal ComputeError");
                    }
                    else
                    {
                        Console.WriteLine($"Day {dayNumber} finished in {stopwatch.ElapsedMilliseconds}ms:\n{computeResult}");
                    }
                    return;
                }
                Console.WriteLine($"The day [args0] must be a number between 1 and {Days.Count}");
                return;
            }
            Console.WriteLine("aoc21 <day> [input-file]");
        }

    }

}