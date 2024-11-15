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

    [Theory(DisplayName = "Triples returns correct scores")]
    [InlineData(new[] { 1,1,1 }, 1000)]
    [InlineData(new[] { 5,5,5 }, 500)]
    [InlineData(new[] { 2,2,2 }, 200)]
    public void Score_Triple_ReturnsCorrectScore(int[] dice, int expectedScore)
    {
        var result = Kata.Score(dice);
        Assert.Equal(expectedScore, result);
    }
}