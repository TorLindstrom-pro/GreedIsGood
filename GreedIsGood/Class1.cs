namespace GreedIsGood;

public static class Kata
{
	public static int Score(int[] dice)
	{
		return dice[0] switch
		{
			1 => 100,
			5 => 50,
			_ => 0
		};
	}
}