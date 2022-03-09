namespace sorting;

public static class SelectionSort 
{
    public static void Go(int[] array) 
    {
        var start = DateTime.Now;
        for (int i = 0; i < array.Length; i++) {
            var min = GetMinimumIndex(array, i);
            Util.Swap(array, i, min);
        }
        var end = DateTime.Now;

        Console.WriteLine("Selection Sort:\t{0} ms", end.Subtract(start).TotalMilliseconds);
    }

    private static int GetMinimumIndex(int[] array, int start) 
    {
        var index = 0;
        var min = 200;
        for (int i = start; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
                index = i;
            }
        }

        return index;
    }
}