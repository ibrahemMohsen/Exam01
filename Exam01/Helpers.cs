using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace Exam01
{
    internal class Helpers
    {
        public static int ParseInt(string? Name, int min = int.MinValue, int max = int.MaxValue)
        {
            do
            {
                Console.WriteLine($"{Name}");
                if (int.TryParse(Console.ReadLine()!, out int result) && result >= min && result <= max)
                {
                    return result;
                }
                Console.WriteLine("Invalid Input. Try Again!");
            } while (true);
        }
    }
}
