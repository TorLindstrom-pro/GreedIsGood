namespace GreedIsGood;

public static class Kata
{
	public static int Score(int[] dice)
	{
		return dice.Select(ScoreOfEachDie).Sum();
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