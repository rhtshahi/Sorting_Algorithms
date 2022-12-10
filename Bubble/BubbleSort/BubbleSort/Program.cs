using System;

namespace Bubble
{
    class BubbleSort
    {
        static void Main(String[] args)
        {
           
            int[] a = { 33, 25, 20, 18, 14, 12, 8, 7, 3, 1 };

            bubble(a);

            for (int x = 0; x < a.Length; x++)
            {
                Console.WriteLine(a[x]);
            }
        }

        static void bubble(int[] a)
        {
            int n = a.Length;
            int i, j, temp;

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[j] < a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}