using DSA.Basics.BinarySearch;

int index, length, searchValue, searchValueIndex;

Console.Write("Enter the number of elements : ");
length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

Console.WriteLine("Enter the elements in sorted order - ");
for (index = 0; index < length; index++)
	array[index] = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the search value : ");
searchValue = Convert.ToInt32(Console.ReadLine());

searchValueIndex = BinarySearch.Search(array, searchValue);

if (searchValueIndex == -1)
	Console.WriteLine("Value " + searchValue + " not present in the array");
else
	Console.WriteLine("Value " + searchValue + " present at index " + searchValueIndex);