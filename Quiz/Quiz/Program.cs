using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Discount20Percent(float amount)
        {
            Console.WriteLine(amount * 0.2f);

        }

        static int MaxOf3Elements(int a, int b, int c)
        {
            if ( a > b)
            {
                if (b > c)
                    return b;
                else if (a > c)
                    return c;
                else
                    return a;
            }
            else
            {
                if (a > c)
                    return a;
                else if (b > c)
                    return c;
                else
                    return b;
            }

        }

        static int Sum3Or5Multiple(int num)
        {
            int result = 0;
            for (int i = 1; i <= num; i++)
                if ((i % 3 == 0) || (i % 5 == 0))
                    result += i;

            return result;
        }

        static float RateOfSmallerAverage(int[] arr)
        {            
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            float average = (float)sum / (float)arr.Length;

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < average)
                    count++;

            return (float)count / (float)arr.Length;
        }

        static float RecalculateAverage(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
                if (max < arr[i])
                    max = arr[i];

            float reSum = 0;

            for (int i = 0; i < arr.Length; i++)
                reSum += (float)arr[i] / (float)max * 100.0f;

            return reSum / (float)arr.Length;

        }

        static char EstimateGrade(float score)
        {
            if (score < 60)
                return 'F';
            else if (score < 70)
                return 'D';
            else if (score < 80)
                return 'C';
            else if (score < 90)
                return 'B';
            else
                return 'A';

        }

        static int CoundWord(char[] chArr)
        {
            int count = 1;
            for (int i = 0; i < chArr.Length; i++)
                if (chArr[i] == ' ')
                    count++;

            return count;
        }

        static string CalculatedDay(int month, int day)
        {
            int[] dayesCount = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] dayArr = new string[] { "Sunday", "Monday", "Tueday", "Wensday", "Thursday", "Friday", "Saturday" };


            int dayes = 0;
            for (int i = 1; i < month; i++)
                dayes += dayesCount[i];

            return dayArr[(dayes + day) % 7];
            
        }

        static void Print10Elements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (i % 10 == 9)
                    Console.WriteLine(arr[i]);
                else
                    Console.Write(arr[i] + " ");

        }

        static void multiplicationTable(int col)
        {
            for (int i = 1; i < 10; i++)
                Console.WriteLine("3 * " + i + " = " + col * i);
        }

        static void ShareCandy(int numCandy, int numChildren, ref int myCandyCount, ref int fatherCandyCount)
        {
            myCandyCount = numCandy / numChildren;
            fatherCandyCount = numCandy - myCandyCount * numChildren;
        }

        static float AverageReScore(int[] arr)
        {
            int sum = 0;
            for ( int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 40)
                    sum += 40;
                else
                    sum += arr[i];
            }

            return (float)sum / (float)arr.Length;
        }

        static void DiliveryThreeFive(int weight)
        {
            int cntFive = weight / 5;
             

            if ( )
            

        }

        static void Main(string[] args)
        {
            // 20% 할인
            Discount20Percent(100.0f);

            // 세 정수 중에서 두 번째로 큰 정수
            Console.WriteLine( MaxOf3Elements(10, 20, 30) );
            Console.WriteLine( MaxOf3Elements(3, 2, 4) );
            Console.WriteLine( MaxOf3Elements(1, 3, 2) );
            
            // 3 또는 5의 배수의 합
            Console.WriteLine( Sum3Or5Multiple(10000) );

            // 평균 보다 작은 요소의 비율
            int[] tmpArr = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(RateOfSmallerAverage(tmpArr));

            // 세준이의 기말고사
            Console.WriteLine(RecalculateAverage(tmpArr));

            // 단어 수 세기
            string strSentence = "The Curious Case of Benjamin Button";
            char[] sentence = strSentence.ToCharArray();
            Console.WriteLine(CoundWord(sentence));

            // 학점
            Console.WriteLine(EstimateGrade(80.0f));

            // 2007년의 요일 계산
            Console.WriteLine(CalculatedDay(3, 1));

            // 한 줄에 10개씩 출력
            Print10Elements(tmpArr);

            // 구구단
            multiplicationTable(3);

            // 캔디 나누기
            int myCandyCount = 0, fatherCandyCount = 0;
            ShareCandy(99, 8, ref myCandyCount, ref fatherCandyCount);
            Console.WriteLine("My Candy Cound : " + myCandyCount + ", Father's Candy : " + fatherCandyCount);

            // 수강생들의 평균 점수 구하기(보강할 경우 40점 이하는 40점)
            int[] score = new int[] { 30, 60, 70, 70, 90 };
            Console.WriteLine(AverageReScore(score));

            // 배달
            DiliveryThreeFive(18);


        }
    }
}
