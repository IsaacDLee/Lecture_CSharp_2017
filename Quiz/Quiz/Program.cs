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
            int reminder = weight - cntFive * 5;
            
            for (; reminder % 3 != 0 ;)
            {
                cntFive--;
                reminder += 5;
            }

            int cntThree = (weight - cntFive * 5) / 3;

            Console.WriteLine("3kg : " + cntThree + ", 5kg : " + cntFive);
            

        }

        static void CountNumber(int pages)
        {            
            int posNum = 0; // 자릿수를 저장           


            //자릿수 계산
            int tmpPages = pages / 10;
            for ( ; tmpPages > 0 ; tmpPages /= 10 )
                posNum++;

            int[] arrPages = new int[posNum + 1];


            tmpPages = pages;
            for ( int i = 0; i < arrPages.Length; i++ )
            {
                arrPages[i] = tmpPages % 10;
                tmpPages /= 10;
            }
            
            int[] countNumArr = new int[10]; // 각 숫자의 개수를 저장

            for (int i = 0; i < countNumArr.Length; i++)
                Console.Write(countNumArr[i] + " ");
            Console.WriteLine();
            
            
        }

        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }

        static int Select(int[] arr, int k)
        {
            int[] biggerArr = new int[arr.Length];
            int[] equalArr = new int[arr.Length];
            int[] smallerArr = new int[arr.Length];


            int cntSmaller = 0;
            int curSelectedNum = 0;
            int curLength = arr.Length;
            int[] tmpArr = arr;

            for (;;)
            {
                curSelectedNum = tmpArr[ curLength / 2];

                int smallerIndex = 0;
                int biggerIndex = 0;
                int equalIndex = 0;

                for (int i = 0; i < curLength; i++)
                    if (tmpArr[i] < curSelectedNum)
                        smallerArr[smallerIndex++] = tmpArr[i];
                    else if (tmpArr[i] > curSelectedNum)
                        biggerArr[biggerIndex++] = tmpArr[i];
                    else
                        equalArr[equalIndex++] = tmpArr[i];

                if (cntSmaller + smallerIndex < k)
                {
                    if (cntSmaller + smallerIndex + equalIndex < k)
                    {
                        cntSmaller += smallerIndex + equalIndex;
                        tmpArr = biggerArr;
                        curLength = biggerIndex;
                    }
                    else if (cntSmaller + smallerIndex + equalIndex > k)
                        return curSelectedNum;
                }
                else if (cntSmaller + smallerIndex > k)
                {
                    tmpArr = smallerArr;
                    curLength = smallerIndex;
                }
                else
                {
                    int max = smallerArr[0];
                    for (int i = 1; i < smallerIndex; i++)
                        if (max < smallerArr[i])
                            max = smallerArr[i];
                    return max;
                }
            }
        }

        static string IsWordInSentence(string str, string word)
        {           

            for ( int i = 0; i < str.Length - word.Length + 1; i++ )
            {
                bool isWord = true;
                for (int j = 0; j < word.Length; j++)
                    if (str[i + j] != word[j])
                        isWord = false;

                if (isWord)
                    return "found";
            }
            return "missing";
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
            //DiliveryThreeFive(21);
            //DiliveryThreeFive(31);

            // 페이지까지의 각 숫자들의 개수
            CountNumber(11);


            //팰린드롬
            Console.WriteLine(IsPalindrome("aba"));
            Console.WriteLine(IsPalindrome("ab%ba"));
            Console.WriteLine(IsPalindrome("9998999"));

            //k번째 숫자
            int[] arrForSelect = new int[] { 3, 5, 1, 5, 6, 7, 100, 45, 33, 97, 47, 32, 66, 103 };
            Console.WriteLine(Select(arrForSelect, 8));

            // "nemo'가 있는지
            //string sentenceForIsWordInSentence = "marlin names this last egg nemo, a name that coral like";
            string sentenceForIsWordInSentence = "a good-hearted and optimistic regal blue tang with short-term memory loss";
            string wordForIsWordInSentence = "nemo";
            Console.WriteLine(IsWordInSentence(sentenceForIsWordInSentence, wordForIsWordInSentence));



        }
    }
}
