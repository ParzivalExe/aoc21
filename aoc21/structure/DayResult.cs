using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.structure
{
    public class DayResult
    {

        public TaskResult[] TaskResults;

        public int TaskCount
        {
            get => TaskResults.Length;
        }

        public DayResult(TaskResult[] taskResults)
        {
            TaskResults = taskResults;
        }

        public override string ToString()
        {
            string message = "";
            int i = 0;
            foreach(TaskResult result in TaskResults)
            {
                message += $"Task{i}: {result}\n";
                i++;
            }
            return message;
        }

    }
}
