using DSA.Basics.MergeSortSubArray;

int index;
int[] array = { 1, 3, 5, 7, 2, 4, 6, 9, 11, 14 };
int[] temp = new int[20];

MergeSort.MergeSubArray(array, temp, 0, 3, 4, 9);

Console.WriteLine("Array is : ");
for (index = 0; index <= 9; index++)
	Console.Write(array[index] + " ");
Console.WriteLine();

Console.WriteLine("Merged array is : ");
for (index = 0; index <= 9; index++)
	Console.Write(temp[index] + " ");
Console.WriteLine();