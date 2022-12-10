using System;

namespace Quick
{
    class QuickSorting
    {
        static void Main(string[] args)
        {
            int[] a = { 17, 14, 12, 13, -2, 8, 16, 1, 13, 33 };
            QuickSort(a, 0, a.Length - 1);
            
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        private static int Partition(int[] array, int left, int right)
        {
            int ndx = left; // pivot index
            int pivot = array[left];
            for (int i = left + 1; i <= right; i++)
            {
                if (array[i] < pivot)
                {
                    ndx++;
                    Swap(array, ndx, i);
                }
            }
            Swap(array, ndx, left);
            return ndx;
        }
        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }
    }
}