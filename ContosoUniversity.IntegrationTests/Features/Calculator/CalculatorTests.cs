namespace ContosoUniversity.IntegrationTests.Features.Calculator
{
    using ContosoUniversity.Features.Calculator;
    using Shouldly;
    using Xunit;

    public class CalculatorTests
    {
        [Fact]
        public void Should_add()
        {
            Calculator.Add(2.5m, 4m).ShouldBe(6.5m);
        }

        [Fact]
        public void Should_subtract()
        {
            Calculator.Subtract(2.5m, 4m).ShouldBe(-1.5m);
        }
    }
}
