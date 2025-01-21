namespace factorialLibrary.Test;

using factorialLibrary;

public class FactorialServiceTests
{
    [Fact]
    public void Test1()
    {
        var res = FactorialService.factorial(0);

        Assert.Equal(1, res);
    }
    [Fact]
    public void TestNegative()
    {
           Assert.Throws<InvalidOperationException>(()=>{
        var res = FactorialService.factorial(-1);
        });
    }
}