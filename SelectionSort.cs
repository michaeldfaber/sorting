namespace sorting;

public static class SelectionSort 
{
    public static int[] Go(int[] array) 
    {
        var start = DateTime.Now;
        for (int i = 0; i < array.Length; i++) {
            var min = GetMinimumIndex(array, i);
            Swap(ref array, i, min);
        }
        var end = DateTime.Now;

        Console.WriteLine("Selection Sort:\t{0} seconds", end.Subtract(start).TotalSeconds);
        return array;
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

    private static void Swap(ref int[] array, int i, int j) 
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}