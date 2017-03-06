using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement
{
    class Program
    {
        static void IsLinesIntersected()
        {
            float line1_start = 0.3f;
            float line1_end = 5.2f;
            float line2_start = 3.2f;
            float line2_end = 3.9f;

            if ( line1_start > line1_end )
            {
                float tmp = line1_end;
                line1_end = line1_start;
                line1_start = tmp;
            }

            if (line2_start > line2_end)
            {
                float tmp = line2_end;
                line2_end = line2_start;
                line2_start = tmp;
            }

            if ((line1_start < line2_start) && (line1_end < line2_start))
                Console.WriteLine("Not Intersected!!!");
            else if ((line2_start < line1_start) && (line2_end < line1_start))
                Console.WriteLine("Not Intersected!!!");
            else
                Console.WriteLine("Intersected!!!");
        }

        static void SumFrom1T0100()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
                sum += i;

            Console.WriteLine(sum);
        }

        static void SumFrom1T0100Even()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
                if ( i % 2 == 0 )
                    sum += i;

            Console.WriteLine(sum);

        }

        static void SumFrom1T0100Odd()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
                if (i % 2 == 1)
                    sum += i;

            Console.WriteLine(sum);

        }
        
        static void PrintStarSqure()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }

        static void PrintStarRightAngleTriangle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }

        static void PrintStarInvertedRightAngleTriangle()
        {
            for (int i = 5; i >0 ; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void PrintStarIsoscelesTriangle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //IsLinesIntersected();
            //SumFrom1T0100();
            //SumFrom1T0100Even();
            //SumFrom1T0100Odd();
            //PrintStarSqure();
            //PrintStarRightAngleTriangle();
            //PrintStarInvertedRightAngleTriangle();
            //PrintStarIsoscelesTriangle();
        }
        
    }
}
