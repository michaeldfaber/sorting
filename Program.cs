using sorting;

// Generate And Print Random Array
var array = Util.GetRandomArray();
Util.PrintArray(array);

SelectionSort.Go((int[])array.Clone());
BubbleSort.Go((int[])array.Clone());
// InsertSort.Go((int[])array.Clone());
// MergeSort.Go((int[])array.Clone());
// QuickSort.Go((int[])array.Clone());

Console.WriteLine();