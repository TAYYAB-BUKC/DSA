using DSA.Basics.HeaderLinkedListProject;

int choice, data, info, position;

HeaderLinkedList List = new HeaderLinkedList();

while (true)
{
	Console.WriteLine("0. Create list"); 
	Console.WriteLine("1. Display list");
	Console.WriteLine("2. Insert a node at the beginning of the list");
	Console.WriteLine("3. Insert a node at the end of the list");
	Console.WriteLine("4. Insert a new node before a node");
	Console.WriteLine("5. Insert at a given position");
	Console.WriteLine("6. Delete a node");
	Console.WriteLine("7. Reverse the list");
	Console.WriteLine("8. Quit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 8)
		break;

	switch (choice)
	{
		case 0:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			List.CreateList(data);
			break;
		case 1:
			List.DisplayList();
			break;
		case 2:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			List.InsertAtBeginning(data);
			break;
		case 3:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			List.InsertAtEnd(data);
			break;
		case 4:

			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the element before which to insert : ");
			info = Convert.ToInt32(Console.ReadLine());
			List.InsertBefore(data, info);
			break;
		case 5:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the position at which to insert : ");
			position = Convert.ToInt32(Console.ReadLine());
			List.InsertAtPosition(data, position);
			break;
		case 6:
			Console.Write("Enter the element to be deleted : ");
			data = Convert.ToInt32(Console.ReadLine());
			List.DeleteNode(data);
			break;
		case 7:
			List.Reverse();
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
}