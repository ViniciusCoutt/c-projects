using CourseLog_Conjuntos.Entities;
using System;
using System.Collections.Generic;

namespace CourseLog_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<CourseLog> set = new HashSet<CourseLog>();

            Console.Write("How many studens for Course A? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++)
            {
                set.Add(new CourseLog(int.Parse(Console.ReadLine())));
            }

            Console.Write("How many studens for Course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                set.Add(new CourseLog(int.Parse(Console.ReadLine())));
            }

            Console.Write("How many studens for Course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                set.Add(new CourseLog(int.Parse(Console.ReadLine())));
            }

            Console.WriteLine("Total students: " + set.Count);

        }
    }
}
