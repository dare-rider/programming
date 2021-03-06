using System;

public class combination
{
	public static long ncr(int n, int r)
	{
		if (r > n || n < 0 || r < 0)
			return -1;
		if (r > n / 2)
			r = n - r;
		long ans = 1;
		for (int i = 1; i <= r; i++)
		{
			ans *= n - r + i;
			ans /= i;
		}
		return ans;
	}

	static void Main(string[] args)
	{
		long combination = ncr(15, 5);
		if (combination > 0)
			Console.WriteLine(combination);
		else
			Console.WriteLine("Invalid Input");
	}
}
