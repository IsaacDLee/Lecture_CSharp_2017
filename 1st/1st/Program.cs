using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!!!");
            int sum = 0;
            int count = 0;

            for (int i = 0; i < 100; i++)
            {
                sum += i;
                count++;
            }

            Console.WriteLine(sum);
            Console.WriteLine(count);

        }
    }
}
