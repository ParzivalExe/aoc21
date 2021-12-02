using System.Reflection;

namespace aoc.structure {

    public abstract class Day {


        public string DefaultPath { get; private set; }

        public Day(string defaultPath)
        {
            DefaultPath = Path.Combine(Environment.CurrentDirectory, defaultPath);
        }

        public string ComputeDefaultDay() => 
            ComputeDay(DefaultPath);


        public string ComputeDay(string path) {
            string[] input = File.ReadAllLines(path);
            return Compute(input);
        }

        protected abstract string Compute(string[] commandLines);

    }

}