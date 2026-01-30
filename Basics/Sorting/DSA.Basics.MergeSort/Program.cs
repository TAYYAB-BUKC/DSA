using DSA.Basics.MergeSort;

int index, firstArrayLength, secondArrayLength;

Console.Write("Enter the number of elements for first firstArray : ");
firstArrayLength = Convert.ToInt32(Console.ReadLine());

int[] firstArray = new int[firstArrayLength];

for (index = 0; index < firstArrayLength; index++)
{
	Console.Write("Enter element " + (index + 1) + " : ");
	firstArray[index] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Enter the number of elements for second firstArray : ");
secondArrayLength = Convert.ToInt32(Console.ReadLine());

int[] secondArray = new int[secondArrayLength];

for (index = 0; index < secondArrayLength; index++)
{
	Console.Write("Enter element " + (index + 1) + " : ");
	secondArray[index] = Convert.ToInt32(Console.ReadLine());
}

int[] mergedArray = new int[firstArrayLength + secondArrayLength];

MergeSort.Sort(firstArray, secondArray, mergedArray, firstArrayLength, secondArrayLength);

Console.WriteLine("Sorted Merged Array Is : ");
for (index = 0; index < firstArrayLength + secondArrayLength; index++)
	Console.Write(mergedArray[index] + " ");

Console.WriteLine();