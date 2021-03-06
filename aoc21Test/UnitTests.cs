using aoc.structure;
using aoc.twentyOne;
using aoc21.structure;
using System.Linq;
using Xunit;

namespace aoc21Test
{
    public class UnitTests
    {

        [Theory]
        //DAY 1
        //Task1
        [InlineData(1, 1, @"inputFiles\Day1Test.txt", 7)]
        //Task2
        [InlineData(1, 2, @"inputFiles\Day1Test.txt", 5)]
        //DAY 2
        //Task1
        [InlineData(2, 1, @"inputFiles\Day2Test.txt", 150)]
        //Task2
        [InlineData(2, 2, @"inputFiles\Day2Test.txt", 900)]
        //DAY 3
        //Task1
        [InlineData(3, 1, @"inputFiles\Day3Test.txt", 198)]
        //Task2
        [InlineData(3, 2, @"inputFiles\Day3Test.txt", 230)]
        public void Tests(int dayInt, int task, string fileName, int result)
        {
            Day day = Program.GetDay(dayInt);
            DayResult actualResult = day.ComputeDay(fileName, task);
            Assert.Equal(result, actualResult.TaskResults.First().Result);
        }


        [Theory]
        //DAY 1
        //Task1
        [InlineData(1, 1, @"inputFiles\Day1Final.txt", 1502)]
        //Task2
        [InlineData(1, 2, @"inputFiles\Day1Final.txt", 1538)]
        //DAY 2
        //Task1
        [InlineData(2, 1, @"inputFiles\Day2Final.txt", 2027977)]
        //Task2
        [InlineData(2, 2, @"inputFiles\Day2Final.txt", 1903644897)]
        //DAY 3
        //Task1
        [InlineData(3, 1, @"inputFiles\Day3Final.txt", 1458194)]
        //Task2
        [InlineData(3, 2, @"inputFiles\Day3Final.txt", 2829354)]
        public void DayTasks(int dayInt, int task, string fileName, int result)
        {
            Day day = Program.GetDay(dayInt);
            DayResult actualResult = day.ComputeDay(fileName, task);
            Assert.Equal(result, actualResult.TaskResults.First().Result);
        }

    }
}