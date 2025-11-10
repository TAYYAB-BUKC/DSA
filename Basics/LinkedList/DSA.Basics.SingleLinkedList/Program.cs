using DSA.Basics.SingleLinkedList;

int choice, data, position, info;

SingleLinkedList list = new SingleLinkedList();

list.CreateList(5);

while (true)
{
	Console.WriteLine("\n1. Display list");
	Console.WriteLine("2. Count the number of nodes");
	Console.WriteLine("3. Search for an element");
	Console.WriteLine("4. Insert in empty list/Insert in beginning of the list");
	Console.WriteLine("5. Insert a node at the end of the list");
	Console.WriteLine("6. Insert a node after a specified node");
	Console.WriteLine("7. Insert a node before a specified node");
	Console.WriteLine("8. Insert a node at a given position");
	Console.WriteLine("9. Delete first node");
	Console.WriteLine("10. Delete last node");
	Console.WriteLine("11. Delete any node");
	Console.WriteLine("12. Reverse the list");
	Console.WriteLine("13. Sort by exchanging data using Bubble Sort");
	Console.WriteLine("14. Sort by exchanging link using Bubble Sort");
	Console.WriteLine("15. Merge two sorted lists by creating a new list");
	Console.WriteLine("16. Quit");

	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 16)
		break;

	switch (choice)
	{
		case 1:
			list.DisplayList();
			break;
		case 2:
			list.CountNodes();
			break;
		case 3:
			Console.Write("Enter the element to be searched : ");
			data = Convert.ToInt32(Console.ReadLine());
			list.SearchList(data);
			break;
		case 4:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			list.InsertAtBeginning(data);
			break;
		case 5:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			list.InsertAtEnd(data);
			break;
		case 6:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the element after which to insert : ");
			info = Convert.ToInt32(Console.ReadLine());
			list.InsertAfter(data, info);
			break;
		case 7:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the element before which to insert : ");
			info = Convert.ToInt32(Console.ReadLine());
			list.InsertBefore(data, info);
			break;
		case 8:
			Console.Write("Enter the element to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the position at which to insert : ");
			position = Convert.ToInt32(Console.ReadLine());
			list.InsertAtPosition(data, position);
			break;
		case 9:
			list.DeleteFirstNode();
			break;
		case 10:
			list.DeleteLastNode();
			break;
		case 11:
			Console.Write("Enter the element to be deleted : ");
			data = Convert.ToInt32(Console.ReadLine());
			list.DeleteNode(data);
			break;
		case 12:
			list.ReverseList();
			break;
		case 13:
			list.SortListByExchangingDataUsingBubbleSort();
			break;
		case 14:
			list.SortListByExchangingLinkUsingBubbleSort();
			break;
		case 15:
			SingleLinkedList secondList = new SingleLinkedList();
			SingleLinkedList newList = new SingleLinkedList();
			list.SortListByExchangingDataUsingBubbleSort();
			secondList.CreateList(5);
			secondList.SortListByExchangingDataUsingBubbleSort();
			newList = list.MergeByCreatingANewList(secondList);
			Console.WriteLine("First List - ");
			list.DisplayList();
			Console.WriteLine("Second List - ");
			secondList.DisplayList();
			Console.WriteLine("Merged List - ");
			newList.DisplayList();
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
	Console.WriteLine();
}

Console.WriteLine("Exiting");