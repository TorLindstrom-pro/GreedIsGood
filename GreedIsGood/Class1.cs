namespace GreedIsGood;

public static class Kata
{
	public static int Score(int[] dice)
	{
		var diceGroups = dice.GroupBy(die => die);

		var tripletsScore = diceGroups
			.Where(group => group.Count() >= 3)
			.Sum(group => ScoreTriplets(group.Key));

		var singlesScore = diceGroups
			.Select(group => (group.Count() % 3, group.Key) )
			.Sum(group => ScoreOfEachDie(group.Key) * group.Item1);

		return tripletsScore + singlesScore;
	}

	private static int ScoreTriplets(int die)
	{
		return die switch
		{
			1 => 1000,
			_ => die * 100
		};
	}

	private static int ScoreOfEachDie(int die)
	{
		return die switch
		{
			1 => 100,
			5 => 50,
			_ => 0
		};
	}
}