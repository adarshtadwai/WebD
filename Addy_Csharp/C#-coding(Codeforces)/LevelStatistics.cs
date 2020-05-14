using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
public class LevelStatistics
{
	public LevelStatistics()
	{
		int Q =	int.Parse(Console.ReadLine());
		while(Q-- > 0)
		{
			int n = int.Parse(Console.ReadLine());
			List<KeyValuePair<int,int> > inp= new List<KeyValuePair<int, int>>();
			for(int i=0;i<n;i++)
			{
				List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
				inp.Add(new KeyValuePair<int, int>(arr[0], arr[1]));
			}
			bool ok = true;
			if (inp[0].Key < inp[0].Value) ok = false;
			for (int i = 1; i < n; i++)
			{
				if (inp[i].Key < inp[i - 1].Key || inp[i].Value < inp[i - 1].Value ||
					(inp[i].Key - inp[i - 1].Key) < inp[i].Value - inp[i - 1].Value)
				{
					ok = false;
				}
			}
			if (ok)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}

	public static void test()
	{
		Console.WriteLine("offffh");
	}
}
