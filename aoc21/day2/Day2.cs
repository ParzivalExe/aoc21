using aoc.structure;
using aoc21.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.day2
{
    internal class Day2 : Day
    {

        public Day2() : base(@"inputFiles\Day2Final.txt") { }

        protected override TaskResult ComputeTask(string[] commandLines, int task)
        {
            Position position;
            if (task == 1)
                position = new Position();
            else
                position = new RealPosition();

            position.ChangePositionBy(commandLines);
            return new TaskResult(position.Result, task, $"The final Position after {commandLines.Count()} commands is:\n  Horizontal = {position.Horizontal}\n  Depth = {position.Depth}\n  Result = {position.Result}");
        }

    }
}
