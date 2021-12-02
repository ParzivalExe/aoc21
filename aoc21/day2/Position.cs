using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.day2
{
    internal class Position
    {

        public int Horizontal { get; protected set; }
        public int Depth { get; protected set; }

        public int Result
        {
            get => Horizontal * Depth;
        }

        public Position()
        {
            Horizontal = 0;
            Depth = 0;
        }

        protected virtual void ChangePositionBy(PositionChangeType changeType, int amount)
        {
            switch(changeType)
            {
                case PositionChangeType.FORWARD:
                    {
                        Horizontal += amount;
                        break;
                    }
                case PositionChangeType.DOWN:
                    {
                        Depth += amount;
                        break;
                    }
                case PositionChangeType.UP:
                    {
                        Depth -= amount;
                        break;
                    }
            }
        }

        public void ChangePositionBy(string command)
        {
            string[] split = command.Split(' ');
            PositionChangeType changeType = PositionChangeTypeHelper.GetByName(split[0]);
            int amount = int.Parse(split[1]);
            ChangePositionBy(changeType, amount);
        }

        public void ChangePositionBy(string[] commands)
        {
            foreach(string command in commands)
            {
                ChangePositionBy(command);
            }
        }

    }

    public enum PositionChangeType
    {
        FORWARD, DOWN, UP
    }

    public static class PositionChangeTypeHelper
    {
        public static PositionChangeType GetByName(string name)
        {
            name = name.ToUpper();
            switch(name)
            {
                case "FORWARD":
                    return PositionChangeType.FORWARD;
                case "DOWN":
                    return PositionChangeType.DOWN;
                case "UP":
                    return PositionChangeType.UP;
                default:
                    throw new ArgumentException("Name can only be 'FORWARD', 'DOWN' and 'UP' (cases ignored)");
            }
        }
    }

}
