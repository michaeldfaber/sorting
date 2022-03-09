using System.Threading;

namespace sorting;

public static class InsertionSort 
{
    public static void Go(int[] array) 
    {
        var start = DateTime.Now;
        for (int i = 1; i < array.Length; i++) 
        {
            var j = i;
            while (j > 0 && array[j] < array[j-1])
            {
                Util.Swap(array, j, j-1);
                j--;
            }
        }
        var end = DateTime.Now;

        Console.WriteLine("Insertion Sort:\t{0} ms", end.Subtract(start).TotalMilliseconds);
    }
}