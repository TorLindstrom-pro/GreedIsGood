using static System.Math;

namespace GreedIsGood;

public static class Kata
{
	public static int Score(int[] dice) => dice
			.GroupBy(die => die)
			.Select(group =>
			{
				var (tripletCount, singlesCount) = DivRem(group.Count(), 3);
				
				var tripletsScore = ScoreTriplets(group.Key, tripletCount);
				var singlesScore = ScoreOfDie(group.Key, singlesCount);
				
				return tripletsScore + singlesScore;
			})
			.Sum();

	private static int ScoreTriplets(int die, int tripletCount)
	{
		var score = die switch
		{
			1 => 1000,
			_ => die * 100
		};
		return score * tripletCount;
	}

	private static int ScoreOfDie(int die, int singlesCount)
	{
		var score = die switch
		{
			1 => 100,
			5 => 50,
			_ => 0
		};
		return score * singlesCount;
	}
}