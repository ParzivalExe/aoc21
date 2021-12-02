using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.day2
{
    internal class RealPosition : Position
    {

        public int Aim { get; protected set; }

        public RealPosition() : base()
        {
            Aim = 0;
        }

        protected override void ChangePositionBy(PositionChangeType changeType, int amount)
        {
            switch(changeType)
            {
                case PositionChangeType.DOWN:
                    {
                        Aim += amount;
                        break;
                    }
                case PositionChangeType.UP:
                    {
                        Aim -= amount;
                        break;
                    }
                case PositionChangeType.FORWARD:
                    {
                        Horizontal += amount;
                        Depth += Aim * amount;
                        break;
                    }
            }
        }

    }
}
