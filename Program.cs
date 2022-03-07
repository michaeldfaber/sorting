using sorting;

// TODO better output
var array = RandomArray.Get();

for (int i = 0; i < array.Length; i++) {
    Console.Write(array[i] + " ");
}
Console.WriteLine();

var sortedArray = SelectionSort.Go(array);

for (int i = 0; i < sortedArray.Length; i++) {
    Console.Write(sortedArray[i] + " ");
}
Console.WriteLine();