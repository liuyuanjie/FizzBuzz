using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_Report_Fizz_When_Reporting_Given_Contains_3()
        {
            var order = 3;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("Fizz", report);
        }
    }
}