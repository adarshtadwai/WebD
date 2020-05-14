using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class MiddleClass
{
	public MiddleClass()
	{
		int Q = int.Parse(Console.ReadLine());
		while (Q-- > 0)
		{
			int[] inp = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
			int n = inp[0], x = inp[1];
			int[] A = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
			long[] pre = new long[n]; Array.Sort(A); Array.Reverse(A);

			pre[0] = A[0];
			for (int j = 1; j < n; j++)
			{
				pre[j] = pre[j - 1] + A[j];
			}
			//PrintArray(pre);
			int i = 0;
			for (; i < n; i++)
				if (pre[i] / (i + 1) < x) break;
			Console.WriteLine(i);
		}
	}
}
