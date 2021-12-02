using aoc.structure;
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

        protected override string Compute(string[] commandLines)
        {
            int previousDepth = -1;
            int increases = 0;
            foreach(string commandLine in commandLines)
            {
                int currentDepth;
                if (!int.TryParse(commandLine, out currentDepth))
                    continue;

                if(currentDepth > previousDepth)
                    increases++;
                previousDepth = currentDepth;
            }
            increases--;
            return $"There are {increases} larger measurements in these values";
        }


    }
}
