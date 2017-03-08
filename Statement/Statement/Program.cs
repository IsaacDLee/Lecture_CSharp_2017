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

            if (line1_start > line1_end)
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
                if (i % 2 == 0)
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
            for (int i = 5; i > 0; i--)
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

        static void PrintStarWindmill()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                for (int j = i; j < 4; j++)
                    Console.Write(' ');
                for (int j = 5; j > i; j--)
                    Console.Write('*');
                Console.WriteLine();

            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > i; j--)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');

                for (int j = 0; j < i; j++)
                    Console.Write(' ');
                for (int j = 5; j > i; j--)
                    Console.Write('*');
                Console.WriteLine();

            }
        }

        static void Fibonacci()
        {
            int fiboTmp1 = 1, fiboTmp2 = 1, fibo = 1;
            int n = 20;

            if (n < 2)
                fibo = 0;

            else
            {
                for (int i = 2; i < n; i++)
                {
                    fibo = fiboTmp1 + fiboTmp2;
                    fiboTmp1 = fiboTmp2;
                    fiboTmp2 = fibo;
                }
            }

            Console.WriteLine("Complete 20th Fibonacci Number!!!");
            Console.WriteLine(fibo);

        }

        static void FillOddNumber()
        {
            int[] score = new int[50];

            for (int i = 0; i < score.Length; i++)
                score[i] = 2 * i + 1;

            Console.WriteLine("Complete Filling Odd Number!!!");
            for (int i = 0; i < score.Length; i++)
                Console.WriteLine(score[i]);

        }


        static void SumValuesInArray()
        {
            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };

            int sum = 0;

            for (int i = 0; i < score.Length; i++)
                sum += score[i];

            Console.WriteLine("Complete Sum!!!");
            Console.WriteLine(sum);
        }

        static void FindMaxInArray()
        {
            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };

            int max = score[0];

            for (int i = 1; i < score.Length; i++)
                if (max < score[i])
                    max = score[i];

            Console.WriteLine("Complete Finding Max!!!");
            Console.WriteLine(max);


        }

        static void FindMinInArray()
        {
            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };

            int min = score[0];

            for (int i = 1; i < score.Length; i++)
                if (min > score[i])
                    min = score[i];

            Console.WriteLine("Complete Finding Min!!!");
            Console.WriteLine(min);


        }

        static void SelectionSort()
        {
            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };


            for (int i = 0; i < score.Length; i++)
            {
                for (int j = i + 1; j < score.Length; j++)
                    if (score[i] > score[j])
                    {
                        int tmp = score[i];
                        score[i] = score[j];
                        score[j] = tmp;

                    }
            }

            Console.WriteLine("Complete Selection Sorting!!!");
            for (int i = 0; i < score.Length; i++)
                Console.WriteLine(score[i]);
        }

        static void BubbleSort()
        {
            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };


            for (int i = 0; i < score.Length; i++)
            {
                for (int j = 0; j < score.Length - i - 1; j++)
                    if (score[j] > score[j + 1])
                    {
                        int tmp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = tmp;

                    }
            }

            Console.WriteLine("Complete Bubble Sorting!!!");
            for (int i = 0; i < score.Length; i++)
                Console.WriteLine(score[i]);
        }

        static void Merge()
        {
            int[] arr1 = new int[] { 3, 4, 7, 10, 15, 19, 23, 25, 40, 42 };
            int[] arr2 = new int[] { 1, 2, 5, 20, 28, 30, 31, 32, 33, 43 };

            int[] arrMerged = new int[20];

            int index1 = 0, index2 = 0, indexMerged = 0;

            for (; index1 < arr1.Length && index2 < arr2.Length;)
            {
                if (arr1[index1] < arr2[index2])
                    arrMerged[indexMerged++] = arr1[index1++];
                else
                    arrMerged[indexMerged++] = arr2[index2++];
            }

            if (index1 < arr1.Length)
                for (; index1 < arr1.Length;)
                    arrMerged[indexMerged++] = arr1[index1++];
            else
                for (; index2 < arr2.Length;)
                    arrMerged[indexMerged++] = arr2[index2++];


            for (int i = 0; i < arrMerged.Length; i++)
                Console.Write(arrMerged[i] + ", ");
        }

        static int Plus(int a, int b)
        {
            return a + b;

        }


        static void SelectionSort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;

                    }
            }

            Console.WriteLine("Complete Selection Sorting!!!");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        static void Merge(int[] merged, int[] input, int leftStart, int leftEnd, int rightStart, int rightEnd)
        {
            int leftIndex = leftStart;
            int rightIndex = rightStart;
            int mergedIndex = leftStart;

            for (; leftIndex <= leftEnd && rightIndex <= rightEnd;)
            {
                if (input[leftIndex] < input[rightIndex])
                    merged[mergedIndex++] = input[leftIndex++];
                else
                    merged[mergedIndex++] = input[rightIndex++];
            }

            if (leftIndex <= leftEnd)
                for (; leftIndex <= leftEnd;)
                    merged[mergedIndex++] = input[leftIndex++];
            else
                for (; rightIndex <= rightEnd;)
                    merged[mergedIndex++] = input[rightIndex++];

        }

        static void MergeSort(int[] sorted, int[] input)
        {
            int[] tmpArr = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
                tmpArr[i] = input[i];

            int leftStart = 0, leftEnd = 0, rightStart = 0, rightEnd = 0;

            for (int i = 1; i < input.Length; i *= 2)
            {
                for (leftStart = 0; leftStart < input.Length - i; leftStart += i * 2)
                {
                    leftEnd = leftStart + i - 1;
                    rightStart = leftStart + i;
                    rightEnd = leftStart + 2 * i - 1;
                    if (rightEnd >= tmpArr.Length)
                        rightEnd = tmpArr.Length - 1;

                    Merge(sorted, tmpArr, leftStart, leftEnd, rightStart, rightEnd);
                }

                for (int j = 0; j < input.Length; j++)
                    tmpArr[j] = sorted[j];
            }

        }

        static void Merge(int[] merge, int[] leftArr, int[] rightArr)
        {
            int leftArrIndex = 0, rightArrIndex = 0, indexMerged = 0;

            for (; leftArrIndex < leftArr.Length && rightArrIndex < rightArr.Length;)
            {
                if (leftArr[leftArrIndex] < rightArr[rightArrIndex])
                    merge[indexMerged++] = leftArr[leftArrIndex++];
                else
                    merge[indexMerged++] = rightArr[rightArrIndex++];
            }

            if (leftArrIndex < leftArr.Length)
                for (; leftArrIndex < leftArr.Length;)
                    merge[indexMerged++] = leftArr[leftArrIndex++];
            else
                for (; rightArrIndex < rightArr.Length;)
                    merge[indexMerged++] = rightArr[rightArrIndex++];
        }

        static void MergeSortRecursive(int[] sorted, int[] input)
        {
            if (input.Length > 1)
            {
                int mid = input.Length / 2;

                int[] leftArr = new int[mid];
                int[] leftSorted = new int[mid];

                int[] rightArr = new int[input.Length - mid];
                int[] rightSorted = new int[input.Length - mid];


                int i = 0;
                for (; i < mid; i++)
                    leftArr[i] = input[i];
                for (; i < input.Length; i++)
                    rightArr[i - mid] = input[i];

                MergeSortRecursive(leftSorted, leftArr);
                MergeSortRecursive(rightSorted, rightArr);
                Merge(sorted, leftSorted, rightSorted);
            }
            else
            {
                sorted[0] = input[0];
            }


        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
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
            //PrintStarWindmill();
            //Fibonacci();

            //FillOddNumber();
            //SumValuesInArray();
            //FindMaxInArray();
            //FindMinInArray();
            //SelectionSort();
            //BubbleSort();
            //Merge();

            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };
            int[] sorted = new int[20];
            //SelectionSort(score);
            MergeSort(sorted, score);
            //MergeSortRecursive(sorted, score);
            PrintArr(sorted);




            //float f1 = 1.0f, f2 = 2.0f;
            //Console.WriteLine(Plus(f1, f2));

        }

    }
}
