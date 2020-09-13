using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(' ');
            int[] intArr = new int[strArr.Length];
            intArr = Array.ConvertAll<string, int>(strArr, x => int.Parse(x));

            Console.WriteLine("Min: " + intArr.Min());
            Console.WriteLine("Max: " + intArr.Max());
            Console.WriteLine("Sum: " + intArr.Sum());
            Console.WriteLine("Average: " + intArr.Average());
            Console.ReadLine();
        }
    }
}
