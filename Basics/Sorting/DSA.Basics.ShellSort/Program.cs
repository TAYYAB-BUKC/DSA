using DSA.Basics.ShellSort;

int index, length;

Console.Write("Enter the number of elements : ");
length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

for (index = 0; index < length; index++)
{
	Console.Write("Enter element " + (index + 1) + " : ");
	array[index] = Convert.ToInt32(Console.ReadLine());
}

ShellSort.Sort(array, length);

Console.WriteLine("Sorted array is : ");
for (index = 0; index < length; index++)
	Console.Write(array[index] + " ");
Console.WriteLine();