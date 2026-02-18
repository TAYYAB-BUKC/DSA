using DSA.Basics.LinearSearchWithSortedArray;

int index, length, searchValue, searchValueIndex;

Console.Write("Enter the number of elements : ");
length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

Console.WriteLine("Enter the elements - ");
for (index = 0; index < length; index++)
	array[index] = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the search value : ");
searchValue = Convert.ToInt32(Console.ReadLine());

searchValueIndex = LinearSearchWithSortedArray.Search(array, length, searchValue);

if (searchValueIndex == -1)
	Console.WriteLine("Value " + searchValue + " not present in the array");
else
	Console.WriteLine("Value " + searchValue + " present at index " + searchValueIndex);