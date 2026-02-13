using DSA.Basics.RadixSort;

Node temp, node, start = null!;
int index, length, info;

Console.WriteLine("Enter number of elements in the list : ");
length = Convert.ToInt32(Console.ReadLine());

for (index = 1; index <= length; index++)  /*Inserting elements in linked list*/
{
	Console.Write("Enter element " + index + " : ");
	info = Convert.ToInt32(Console.ReadLine());

	temp = new Node(info);
	if (start == null)
		start = temp;
	else
	{
		node = start;
		while (node.link != null)
			node = node.link;
		node.link = temp;
	}
}

start = RadixSort.Sort(start, length);

Console.WriteLine("Sorted list is : ");
node = start;
while (node != null)
{
	Console.Write(node.info + " ");
	node = node.link;
}
Console.WriteLine();
Console.ReadKey();