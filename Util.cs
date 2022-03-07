namespace sorting;

public static class Util 
{
    public static int[] GetRandomArray() 
    {
        var rand = new Random();
        var length = rand.Next(100, 300);
        var array = new int[length];

        for (int i = 0; i < length; i++) {
            array[i] = rand.Next(101);
        }

        return array;
    }

    public static void PrintArray(int[] array) 
    {
        Console.WriteLine();
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++) {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1] + "]");
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void Swap(ref int[] array, int i, int j) 
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}