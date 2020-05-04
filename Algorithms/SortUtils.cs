using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedMS = new List<int>();
            List<int> sorted;

            Random random = new Random();

            Console.WriteLine("MergeSort");
            Console.WriteLine("Unsorted Array: ");
            for (int i = 0; i < 20; i++)
            {
                unsortedMS.Add(random.Next(0, 100));
                Console.Write(unsortedMS[i] + " ");
            }
            Console.WriteLine();

            sorted = MergeSort(unsortedMS);

            Console.WriteLine("Sorted Array: ");

            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n-------------------------------------------------------------------\n");
            Console.WriteLine("QuickSort");
            List<int> unsortedQS = new List<int>();
            Console.WriteLine("Unsorted Array: ");

            for (int i = 0; i < 20; i++)
            {
                unsortedQS.Add(random.Next(0, 100));
                Console.Write(unsortedQS[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorted Array: ");

            QuickSort(unsortedQS, 0, unsortedQS.Count() - 1);

            foreach (int x in unsortedQS)
            {
                Console.Write(x + " ");
            }

            Console.Write("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Binary Search - Iterative");

            List<int> array = new List<int> { 1, 3, 5, 7, 9, 13, 16, 17, 18, 20, 24, 27, 30, 33, 36, 39, 44, 46};
            
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
            Console.Write("Searching for 3:\n");

            Console.WriteLine(BinarySearch(array, 3));
            Console.Write("\n");
            Console.Write("Searching for 46:\n");
            Console.WriteLine(BinarySearch(array, 46));

        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;

            //divide the unsorted list

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);

        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)

                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }

        private static void QuickSort(List<int> array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        private static int Partition(List<int> array, int low, int high)
        {
            int pivot = array[high];
            int lowIndex = low - 1;

            for (int i = low; i < high; i++)
            {
                if (array[i] <= pivot)
                {
                    lowIndex++;
                    int tmp = array[lowIndex];
                    array[lowIndex] = array[i];
                    array[i] = tmp;
                }
            }

            int temp = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp;

            return lowIndex + 1;
        }

        private static int? BinarySearch(List<int> array, int item)
        {
            int low = 0;
            int high = array.Count - 1;

            while (low <= high)
            {
                int mid = (high + low ) / 2;
                int guess = array[mid];
                Console.WriteLine("guess: " + guess);
                if (guess == item)
                {
                    return mid;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else 
                {
                    low = mid + 1;
                }
            }
            return null;
        }
    }
}
