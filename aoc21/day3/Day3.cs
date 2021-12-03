using aoc.structure;
using aoc21.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.day3
{
    internal class Day3 : Day
    {

        public Day3() : base(@"inputFiles\Day3Final.txt") { }

        protected override TaskResult ComputeTask(string[] commandLines, int task)
        {
            switch(task)
            {
                case 1:
                    {
                        ByteCalculator calculator = new ByteCalculator(commandLines);
                        int result = calculator.CalculateValue();
                        return new TaskResult(result, 1, $"The Final Value is {result} based on GammaRate {calculator.CalculateGammaRage()} and EpsilonRate {calculator.CalculateEpsilonRate()}");
                    }
                case 2:
                    {
                        LSRCalculator calculator = new LSRCalculator(commandLines);
                        int result = calculator.CalculateValue();
                        return new TaskResult(result, 2, $"The Final Value is {result} based on OxygenGenerator-Rating {calculator.CalculateOxygenGenerator()} and CO2-Scrubber Rating {calculator.CalculateCO2Scrubber()}");
                    }
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
