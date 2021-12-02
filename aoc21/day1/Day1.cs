using aoc.structure;
using aoc21.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.day1
{
    internal class Day1 : Day
    {

        public Day1() : base(@"inputFiles\Day1Final.txt") { }

        protected override TaskResult ComputeTask(string[] commandLines, int task)
        {
            switch (task)
            {
                case 1:
                    {
                        int result = TaskOne(commandLines);
                        return new TaskResult(result, 1, $"There are {result} larger measurements in these values");
                    }
                case 2:
                    {
                        int result = TaskTwo(commandLines);
                        return new TaskResult(result, 2, $"There are {TaskTwo(commandLines)} larder measurements in these sums");
                    }
                default:
                    throw new NotImplementedException();
            }


        }

        private int TaskOne(string[] commandLines)
        {
            int[] depthGroups = commandLines.Select(x => int.Parse(x)).ToArray();
            return GetIncreaseAmount(depthGroups) - 1;
        }

        private int TaskTwo(string[] commandLines)
        {
            if (commandLines.Length <= 2)
                return 0;

            int cacheOne = 0;
            int cacheTwo = 0;

            int.TryParse(commandLines[0], out cacheOne);
            int.TryParse(commandLines[1], out cacheTwo);

            int[] depthGroups = new int[commandLines.Length - 2];
            for (int i = 2; i < depthGroups.Length; i++)
            {
                int currentDepth;
                if (!int.TryParse(commandLines[i], out currentDepth))
                    continue;
                depthGroups[i] = cacheOne + cacheTwo + currentDepth;

                cacheOne = cacheTwo;
                cacheTwo = currentDepth;
            }

            return GetIncreaseAmount(depthGroups);
        }

        private int GetIncreaseAmount(int[] depths)
        {
            int previousDepth = -1;
            int increases = 0;
            foreach (int currentDepth in depths)
            {
                if (currentDepth > previousDepth)
                    increases++;
                previousDepth = currentDepth;
            }
            return increases;
        }

    }
}
