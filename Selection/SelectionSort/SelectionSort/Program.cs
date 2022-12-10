using System;

namespace Selection
{
    class SelectionSort
    {
        static void Main(String[] args)
        {

            int[] userIn = { 17, 10, 4, 8, 16, -3, 38, 2, 11, 22};

            selection(userIn);

            for (int x = 0; x < userIn.Length; x++)
            {
                Console.WriteLine(userIn[x]);
            }

        }


        static void selection(int[] a)
        {
            int i, j, small;
            int n = a.Length;

            for(i=0; i<n-1; i++)
            {
                small = i;

                for(j=i+1; j<n; j++)
                {
                    if(a[j] < a[small])
                    {
                        small = j;
                    }
                }

                int temp = a[small];
                a[small] = a[i];
                a[i] = temp;

              
            }
        }
    }
    
}
