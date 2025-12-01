namespace csharp.SortAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            if (array == null) return;
            if (array.Length <= 1) return;
            int[] aux = new int[array.Length];
            SortInternal(array, aux, 0, array.Length - 1);
        }

        private static void SortInternal(int[] a, int[] aux, int left, int right)
        {
            if (left >= right) return;
            int mid = left + (right - left) / 2;
            SortInternal(a, aux, left, mid);
            SortInternal(a, aux, mid + 1, right);
            Merge(a, aux, left, mid, right);
        }

        private static void Merge(int[] a, int[] aux, int left, int mid, int right)
        {
            int i = left, j = mid + 1, k = left;
            // Copy to aux
            for (int t = left; t <= right; t++) aux[t] = a[t];

            while (i <= mid && j <= right)
            {
                if (aux[i] <= aux[j]) a[k++] = aux[i++];
                else a[k++] = aux[j++];
            }
            while (i <= mid) a[k++] = aux[i++];
            while (j <= right) a[k++] = aux[j++];
        }
    }
}
