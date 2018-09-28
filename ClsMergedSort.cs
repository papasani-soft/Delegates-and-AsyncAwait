using System;
using System.Collections.Generic;
using System.Text;

namespace async_await
{
    class ClsMergedSort
    {
        public static void CreateMergeSort()
        {
            int[] a = { 5, 4, 8, 6, 2};
            int[] b = { 1, 7, 9, 10,11};
            int[] c=new int[5];
            int k = 0;
            for (int i = 0; i <4 ; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i] < b[j])
                    {
                        c[k++] = a[i];
                    }
                    else
                    {
                        c[k++] = b[i];
                    }
                }
            }
            for (int l = 0; l < c.Length; l++)
            {
                Console.Write(c[l]+" ");
            }


        }
    }
}
