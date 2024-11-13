using GreedIsGood;

namespace Test;

public class UnitTest1
{
    [Theory(DisplayName = "A single dice returns correct points")]
    [InlineData(1, 100)]
    [InlineData(5, 50)]
    public void Score_ReturnsANumber(int dice, int expectedScore)
    {
        var result = Kata.Score([dice]);
        Assert.Equal(expectedScore, result);
    }
}