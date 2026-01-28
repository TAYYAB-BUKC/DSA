using DSA.Basics.SelectionSort;

int index, numberOfElements;

Console.Write("Enter the number of elements : ");
numberOfElements = Convert.ToInt32(Console.ReadLine());

int[] array = new int[numberOfElements];

for (index = 0; index < numberOfElements; index++)
{
	Console.Write("Enter element " + (index + 1) + " : ");
	array[index] = Convert.ToInt32(Console.ReadLine());
}

SelectionSort.Sort(array, numberOfElements);

Console.WriteLine("Sorted array is : ");
for (index = 0; index < numberOfElements; index++)
	Console.Write(array[index] + " ");
Console.WriteLine();