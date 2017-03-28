using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {

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

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;

        }

        static void QuickSort(int[] arr, int first, int last)
        {
            if ( last - first < 2 )
            {
                if (arr[first] > arr[last])
                    Swap(ref arr[first], ref arr[last]);
            }
            else
            {
                int curfirst = first;
                int curLast = last;
                int pivot = arr[(first + last) / 2];
                
                while (curfirst < curLast)
                {
                    while (arr[curfirst] < pivot)
                        curfirst++;
                    while (arr[curLast] > pivot)
                        curLast--;
                    if ( curfirst < curLast )
                        Swap(ref arr[curfirst++], ref arr[curLast--]);
                }

                QuickSort(arr, first, curLast);
                QuickSort(arr, curfirst, last);

            }
        }

        static void QuickSortRecursive(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);

        }

        static void QuickSort(int[] arr)
        {

        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        static void Main(string[] args)
        {

            int[] score = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };
            int[] sorted = new int[20];

            //SelectionSort(score);
            //MergeSort(sorted, score);
            //MergeSortRecursive(sorted, score);
            //PrintArr(sorted);

            QuickSortRecursive(score);
            PrintArr(score);



        }
    }
}
