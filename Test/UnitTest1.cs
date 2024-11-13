using GreedIsGood;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "Score returns a number")]
    public void Score_ReturnsANumber()
    {
        var result = Kata.Score([]);
        Assert.Equal(0, result);
    }
}