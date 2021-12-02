using aoc21.structure;
using System.Reflection;

namespace aoc.structure {

    public abstract class Day {


        public string DefaultPath { get; private set; }

        public int Task;

        public Day(string defaultPath)
        {
            DefaultPath = Path.Combine(Environment.CurrentDirectory, defaultPath);
            Task = 0;
        }


        public DayResult ComputeDefaultDay() =>
            ComputeDefaultDay(0);

        public DayResult ComputeDay(string path) =>
            ComputeDay(path, 0);

        public DayResult ComputeDefaultDay(int task) => 
            ComputeDay(DefaultPath, task);


        public DayResult ComputeDay(string path, int task) {
            string[] input = File.ReadAllLines(path);
            switch(task)
            {
                case 1:
                    return new DayResult(new TaskResult[] { ComputeTask(input, 1) });
                case 2:
                    return new DayResult(new TaskResult[] { ComputeTask(input, 2) });
                default:
                    return new DayResult(new TaskResult[] { ComputeTask(input, 1), ComputeTask(input, 2) });
            }
        }

        protected abstract TaskResult ComputeTask(string[] commandLines, int task);

    }

}