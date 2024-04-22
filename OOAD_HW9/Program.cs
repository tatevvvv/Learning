// See https://aka.ms/new-console-template for more information
using OOAD_HW9;
using OOAD_HW9.Problem1;
using OOAD_HW9.Problem2;

Console.WriteLine("Testing Problem 1");
var array = new List<int> { 9, 3, 1, 4, 10, 2, 6, 5, 7, 8 };

OOAD_HW9.Problem1.SortingStrategy sortingStrategy = new InsertionSort();
OOAD_HW9.Problem1.Client client1 = new OOAD_HW9.Problem1.Client(sortingStrategy, array);
client1.Sort();

Console.WriteLine("printing after sort");

foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Testing Problem 2");

BinaryTree leafD = new NonEmpty(Empty.getInstance(), Empty.getInstance(), "D");

BinaryTree leafH = new NonEmpty(Empty.getInstance(), Empty.getInstance(), "H");

BinaryTree leafI = new NonEmpty(Empty.getInstance(), Empty.getInstance(), "I");

BinaryTree leafJ = new NonEmpty(Empty.getInstance(), Empty.getInstance(), "J");

BinaryTree treeE = new NonEmpty(leafH, Empty.getInstance(), "E");

BinaryTree treeB = new NonEmpty(leafD, treeE, "B");

BinaryTree treeF = new NonEmpty(Empty.getInstance(), leafI, "F");
BinaryTree treeG = new NonEmpty(leafJ, Empty.getInstance(), "G");
BinaryTree treeC = new NonEmpty(treeF, treeG, "C");

BinaryTree treeA = new NonEmpty(treeB, treeC, "A");

OOAD_HW9.Problem2.Client client2 = new OOAD_HW9.Problem2.Client(treeA);


Console.WriteLine("number of leaves is " + client2.getNumberOfLeaves());
Console.WriteLine("height is " + client2.getHeight());
Console.WriteLine("size is " + client2.getSize());