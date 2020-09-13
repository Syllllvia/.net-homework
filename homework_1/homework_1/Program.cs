using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime factor is: ");
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    n /= i;
                    Console.WriteLine(i);
                    
            }
            Console.WriteLine("Over");
        }
    }
}

