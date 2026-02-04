using DSA.Basics.MergeSortIterative;

int index, arrayLength;

Console.Write("Enter the number of elements : ");
arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrayLength];

for (index = 0; index < arrayLength; index++)
{
	Console.Write("Enter element " + (index + 1) + " : ");
	array[index] = Convert.ToInt32(Console.ReadLine());
}

MergeSort.Sort(array, arrayLength);

Console.WriteLine("Sorted Array : ");
for (index = 0; index < arrayLength; index++)
	Console.Write(array[index] + " ");

Console.WriteLine();