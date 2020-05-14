using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

//https://codeforces.com/contest/1337/problem/A

public class IchihimeAndTriangle
{
	public IchihimeAndTriangle()
	{
        int Q = int.Parse(Console.ReadLine());
        while (Q-- > 0)
        {
            List<int> A = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            Console.Write(A[1] + " " + A[2] + " " + A[2] + '\n');
        }
    }
}
