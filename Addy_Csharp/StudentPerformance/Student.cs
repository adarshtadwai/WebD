using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace StudentPerformance
{
    class Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Subjects and Marks in each Subjects");
            var Student = new Analysis();
            Student.input();
            Student.Analyse();
            string decide;
            do
            {
                Console.WriteLine("Another Subject Mark to Enter?   Yes/No");
                decide = Console.ReadLine();
                if (decide == "Yes")
                {
                    Student.AddToList();
                }
                else
                {
                    break;
                }
            } while (decide != "No");
            Student.Analyse();

        }
    }
}
