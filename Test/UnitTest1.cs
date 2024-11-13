using GreedIsGood;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "A single one returns 100 points")]
    public void Score_ReturnsANumber()
    {
        var result = Kata.Score([1]);
        Assert.Equal(100, result);
    }
}