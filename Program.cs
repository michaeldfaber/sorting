using sorting;

// Generate And Print Random Array
var array = Util.GetRandomArray();
Util.PrintArray(array);

SelectionSort.Go(Util.CloneArray(array));
InsertionSort.Go(Util.CloneArray(array));
BubbleSort.Go(Util.CloneArray(array));

// MergeSort.Go((int[])array.Clone());
// QuickSort.Go((int[])array.Clone());

Console.WriteLine();