using aoc.structure;
using aoc21.day1;
using aoc21.day2;
using aoc21.structure;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace aoc.twentyOne
{

    public class Program
    {

        public static List<Day> Days = new List<Day>()
        {
            new Day1(), new Day2()
        };

        public static void Main(string[] args)
        {
            if(args.Length >= 1 && args.Length <= 3)
            {
                int dayNumber = -1;
                int taskNumber = 0;
                if(int.TryParse(args[0], out dayNumber))
                {
                    if(args.Length >= 2)
                        int.TryParse(args[1], out taskNumber);
                    Day day = GetDay(dayNumber);

                    string path = args.Length >= 2 ? args[1] : day.DefaultPath;

                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    DayResult result = day.ComputeDay(path, taskNumber);

                    stopwatch.Stop();

                    if(result == null)
                    {
                        Console.WriteLine($"Compute of Day {dayNumber} with InputeFile {path} has resulted in internal ComputeError");
                    }
                    else
                    {
                        Console.WriteLine($"Day {dayNumber} finished in {stopwatch.ElapsedMilliseconds}ms:\n{result}");
                    }
                    return;
                }
                Console.WriteLine($"The day [args0] must be a number between 1 and {Days.Count}");
                return;
            }
            Console.WriteLine("aoc21 <day> [task] [input-file]");
        }

        public static Day GetDay(int day) =>
            Days[day-1];

    }

}