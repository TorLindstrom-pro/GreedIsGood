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

    [Theory(DisplayName = "Two dice returns correct points")]
    [InlineData(new[] { 1,1 }, 200)]
    [InlineData(new[] { 1,5 }, 150)]
    [InlineData(new[] { 1,2,3 }, 100)]
    public void Score_TwoDice_GivesCorrectScore(int[] dice, int expectedScore)
    {
        var result = Kata.Score(dice);
        Assert.Equal(expectedScore, result);
    }

    [Fact(DisplayName = "Triple 1 returns 1000")]
    public void Score_Triple_ReturnsCorrectScore()
    {
        var result = Kata.Score([1, 1, 1]);
        Assert.Equal(1000, result);
    }
}