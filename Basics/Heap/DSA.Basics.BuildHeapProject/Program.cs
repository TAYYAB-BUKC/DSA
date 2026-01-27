int[] heap = { 99999, 1, 4, 5, 7, 9, 10 };

int choice;

while (true)
{
	Console.WriteLine("1. Reinitialize (heap = 99999, 1, 4, 5, 7, 9, 10)");
	Console.WriteLine("2. Build TopDown Heap");
	Console.WriteLine("3. Build BottomUp Heap");
	Console.WriteLine("4. Display");
	Console.WriteLine("5. Exit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 5)
		break;

	switch (choice)
	{
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
}