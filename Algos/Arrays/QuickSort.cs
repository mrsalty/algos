namespace Algos.Arrays
{
    public class QuickSort
    {
        public void Sort(int[] arr, int leftIndex, int rightIndex)
        {
            int pivotValue;
            int i;
            int j;

            for (pivotValue = arr[(leftIndex + rightIndex)/2], i = leftIndex, j = rightIndex; i <= j;)
            {
                while (arr[i] < pivotValue)
                {
                    i++;
                }

                while (arr[j] > pivotValue)
                {
                    j--;
                }

                if (i <= j)
                {
                    if (i < j)
                    {
                        var tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }

                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                Sort(arr, leftIndex, j);
            }

            if (i < rightIndex)
            {
                Sort(arr, i , rightIndex);
            }
        }
    }
}
