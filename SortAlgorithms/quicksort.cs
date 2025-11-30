namespace csharp.SortAlgorithms{
    public class QuickSorting
    {
        public static void QuickSort(int[] a)
        {
            if (a == null) return;
            QuickSortInternal(a, 0, a.Length - 1);
        }

    private static void QuickSortInternal(int[] a, int lo, int hi)
    {
        if (lo >= hi) return;
        int p = Partition(a, lo, hi);
        QuickSortInternal(a, lo, p - 1);
        QuickSortInternal(a, p + 1, hi);
    }

    private static int Partition(int[] a, int lo, int hi)
    {
        int pivot = a[hi];
        int i = lo;
        for (int j = lo; j < hi; j++)
        {
        if (a[j] < pivot)
        {
            (a[i], a[j]) = (a[j], a[i]);
            i++;
        }
        }
        (a[i], a[hi]) = (a[hi], a[i]);
    return i;
    }
    }
}