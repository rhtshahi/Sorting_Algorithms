using System;

namespace Insertion
{

    class InsertionSort
    {
        static void Main(String[] args)
        {
            int[] userIn = { 2, 12, 32, 7, 1, 12, 23, -3, -45 };

            insertion(userIn);

            for(int x = 0; x < userIn.Length; x++)
            {
                Console.WriteLine(userIn[x]);
            }

        }

        static void insertion(int[] a)
        {
            int i, j, temp;
            int n = a.Length;

            for(i=1; i<n; i++)
            {
                temp = a[i];
                j = i - 1;

                while(j>=0 && temp <= a[j])
                {
                    a[j + 1] = a[j];
                    j=j-1;
                }

                a[j+1]=temp;
            }
        }
    }

}
