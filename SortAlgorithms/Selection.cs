using System;
using System.Collections.Generic;

namespace csharp.SortAlgorithms
{
    public class SelectionSort
    {
        public static void Selection<T>(T[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            var cmp = Comparer<T>.Default;
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (cmp.Compare(array[j], array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    T temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}