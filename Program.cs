﻿using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2021, 9, 12);
            DateTime date2 = new DateTime(1980, 2, 11);
            TimeSpan time = date.Subtract(date2);

            Console.Write("Differences: ");
            Console.WriteLine($"{Math.Floor((float)(time.Days / 360.0))} years, {Math.Floor((float)((time.Days % 360) / 30))} months, {Math.Floor((float)(time.Days % 360) % 30)} days.");
        }
    }
}
