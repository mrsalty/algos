namespace Algos.Arrays
{
    public class BinarySearch
    {
        public int SearchArray(int[] arr, int value)
        {
            int leftIndex;
            int middleIndex;
            int rightIndex;
            var arrLength = arr.Length;

            if (arrLength <= 0) return -1;

            for (leftIndex = 0, rightIndex = arrLength, middleIndex = (leftIndex + rightIndex)/2;
                (leftIndex <=rightIndex) && arr[middleIndex] != value;
                middleIndex = (leftIndex + rightIndex) / 2)
            {
                if (arr[middleIndex] > value)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return (leftIndex <= rightIndex) ? middleIndex : -1;
        }
    }
}
