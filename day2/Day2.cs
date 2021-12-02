using aoc.structure;
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

        protected override string Compute(string[] commandLines)
        {
            Position position = new Position();
            position.ChangePositionBy(commandLines);
            return $"The final Position after {commandLines.Count()} commands is:\n  Horizontal = {position.Horizontal}\n  Depth = {position.Depth}\n  Result = {position.Result}";
        }
    }
}
