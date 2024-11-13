using GreedIsGood;

namespace Test;

public class UnitTest1
{
    [Theory(DisplayName = "A single dice returns correct points")]
    [InlineData(1, 100)]
    [InlineData(5, 50)]
    [InlineData(2, 0)]
    [InlineData(3, 0)]
    public void Score_SingleDiceGivesCorrectScores(int dice, int expectedScore)
    {
        var result = Kata.Score([dice]);
        Assert.Equal(expectedScore, result);
    }
}