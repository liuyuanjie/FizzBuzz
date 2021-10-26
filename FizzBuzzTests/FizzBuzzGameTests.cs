using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_Report_Fizz_When_Reporting_Given_Contains_3()
        {
            var order = 13;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("Fizz", report);
        }

        [Fact]
        public void Should_Report_Fizz_When_Reporting_Given_Divide_3()
        {
            var order = 6;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("Fizz", report);
        }
        
        [Fact]
        public void Should_Report_Buzz_When_Reporting_Given_Divide_5()
        {
            var order = 10;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("Buzz", report);
        }
        
        [Fact]
        public void Should_Report_Whizz_When_Reporting_Given_Divide_7()
        {
            var order = 14;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("Whizz", report);
        }

        [Fact]
        public void Should_Report_FizzBuzz_When_Reporting_Given_Divide_3_And_5()
        {
            var order = 15;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("FizzBuzz", report);
        }

        [Fact]
        public void Should_Report_FizzWhizz_When_Reporting_Given_Divide_3_And_7()
        {
            var order = 21;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("FizzWhizz", report);
        }
        
        [Fact]
        public void Should_Report_BuzzWhizz_When_Reporting_Given_Divide_5_And_7()
        {
            var order = 70;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("BuzzWhizz", report);
        }
        
        [Fact]
        public void Should_Report_FizzBuzzWhizz_When_Reporting_Given_Divide_3_And_5_And_7()
        {
            var order = 210;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal("FizzBuzzWhizz", report);
        }
        
        [Fact]
        public void Should_Report_Input_When_Reporting_Given_Can_Not_Divide_3_Or_5_Or_7()
        {
            var order = 22;
            var report = FizzBuzzGame.Report(order);
            Assert.Equal(order.ToString(), report);
        }
    }
}