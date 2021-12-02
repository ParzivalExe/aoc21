using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.structure
{
    public class TaskResult
    {

        public int Result { get; }

        public int TaskNumber { get; }

        private string _resultMessage;

        public TaskResult(int result, int taskNumber, string resultMessage)
        {
            Result = result;
            TaskNumber = taskNumber;
            _resultMessage = resultMessage;
        }

        public override string ToString() =>
            _resultMessage;

    }
}
