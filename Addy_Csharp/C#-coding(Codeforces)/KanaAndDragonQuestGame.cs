using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
public class KanaAndDragonQuestGame
{
	public KanaAndDragonQuestGame()
	{
        int Q = int.Parse(Console.ReadLine());
        while (Q-- > 0)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            int x = arr[0], n = arr[1], m = arr[2];
            while (x > 20 && n > 0)
            {
                x = x / 2 + 10;
                n--;
            }
            while (x > 0 && m > 0)
            {
                x = x - 10;
                m--;
            }
            if (x <= 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
