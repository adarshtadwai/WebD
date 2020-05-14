using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class KuroniAndTheGifts
{
    public static void PrintList(List<int> A)
    {
        foreach (int ele in A)
        {
            Console.Write(ele + " ");
        }
        Console.WriteLine();
    }
    public KuroniAndTheGifts()
	{
        int Q = int.Parse(Console.ReadLine());
        while (Q-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> A = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            List<int> B = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            A.Sort(); B.Sort();
            PrintList(A);
            PrintList(B);
        }
    }
}
