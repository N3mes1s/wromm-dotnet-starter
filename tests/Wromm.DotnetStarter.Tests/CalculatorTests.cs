using Xunit;

namespace Wromm.DotnetStarter.Tests;

public sealed class CalculatorTests
{
    [Fact]
    public void AddReturnsSum()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }
}
