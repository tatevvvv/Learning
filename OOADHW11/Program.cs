using OOADHW11;
using OOADHW11.SortingAlgorithms;
using System.Diagnostics;

var size = 1_000_000;

var array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = size - i;
}

Stopwatch stopwatch = new();
Subject insertionSort = new InsertionSort();
Subject partialSort = new PartialSort(172, insertionSort);

Client client = new Client(insertionSort, array);

stopwatch.Start();
client.sort();
stopwatch.Stop();

var T1 = stopwatch.ElapsedMilliseconds * 1000;
Console.WriteLine($"Insertion sort took {T1} microseconds");

client.Subject = partialSort;

// reseting array to its initial state again
for (int i = 0; i < size; i++)
{
    array[i] = size - i;
}
client.Sequence = array;

stopwatch.Restart();
client.sort();
stopwatch.Stop();

var T2 = stopwatch.ElapsedMilliseconds * 1000;
Console.WriteLine($"Partial sort took {T2} microseconds");


Console.WriteLine(T1 > T2 ? "T1 is greater than T2" : T1 < T2 ? "T2 is greater than T1" : "T1 equals to T2");


// T2 should be < than T1 , since asymptotic order can be reduced to O(n
// 5 / 3) by first applying Partial Insertion Sort
// with h to the original array, and then Insertion Sort to the resulting array.