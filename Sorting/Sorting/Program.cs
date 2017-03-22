using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
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
        static void Main(string[] args)
        {
        }
    }
}
