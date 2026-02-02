using DSA.Basics.MergeSortRecursive;

int index, length;

Console.Write("Enter the number of elements : ");
length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];
int[] mergedArray = new int[length];

for (index = 0; index < length; index++)
{
	Console.Write("Enter element " + (index + 1) + " : ");
	array[index] = Convert.ToInt32(Console.ReadLine());
}

MergeSort.Sort(array, mergedArray, 0, length - 1);

Console.WriteLine("Sorted array is : ");
for (index = 0; index < length; index++)
	Console.Write(array[index] + " ");
Console.WriteLine();