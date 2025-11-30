using DSA.Basics.CircularLinkedList;

int choice, data, info;

CircularLinkedList List = new CircularLinkedList();

while (true)
{
	Console.WriteLine("1. Create list");
	Console.WriteLine("2. Display list");
	Console.WriteLine("3. Insert in the beginning");
	Console.WriteLine("4. Insert at the end");
	Console.WriteLine("5. Insert after a node");
	Console.WriteLine("6. Delete first node");
	Console.WriteLine("7. Delete last node");
	Console.WriteLine("8. Delete any node");
	Console.WriteLine("9. Concatenate list");
	Console.WriteLine("10. Quit");

	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 10)
		break;

	switch (choice)
	{
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
	Console.WriteLine();
}
Console.WriteLine("Exiting");