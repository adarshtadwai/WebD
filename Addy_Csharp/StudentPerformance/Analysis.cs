using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Analysis
{
	private int NumberofSubjects;
	private List<double> Marks_List = new List<double>();
	private double max_mark = double.MinValue, min_mark = double.MaxValue, avg_mark;
	public void Analyse()
	{
		double avg = 0;
		foreach (double mark in Marks_List)
		{
			max_mark = Math.Max(max_mark, mark);
			min_mark = Math.Min(min_mark, mark);
			avg += mark;
		}
		avg /= NumberofSubjects;
		avg_mark = avg;
		Console.Write("Student Analysis is as follows\n");
		Console.WriteLine("Highest Mark : " + max_mark);
		Console.WriteLine("Least Mark : " + min_mark);
		Console.WriteLine("Average Mark :" + avg_mark);
	}

	public void input()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		NumberofSubjects = n;
		Marks_List = Console.ReadLine().Trim().Split().Select(double.Parse).ToList();
	}

	public void AddToList()
	{
		Console.WriteLine("Enter marks of the subject");
		NumberofSubjects++;
		double ele = double.Parse(Console.ReadLine());
		Marks_List.Add(ele);
	}

}
