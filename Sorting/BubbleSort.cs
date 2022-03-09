namespace sorting;

public static class BubbleSort 
{
    public static void Go(int[] array) 
    {
        var start = DateTime.Now;
        var sorted = false;
        while (sorted == false) 
        {
            var iterationSorted = true;
            for (int i = 0; i < array.Length - 1; i++) {
                if (array[i] > array[i + 1])
                {
                    iterationSorted = false;
                    Util.Swap(array, i, i+1);
                }
            }
            sorted = iterationSorted;
        }
        var end = DateTime.Now;

        Console.WriteLine("Bubble Sort:\t{0} ms", end.Subtract(start).TotalMilliseconds);
    }
}