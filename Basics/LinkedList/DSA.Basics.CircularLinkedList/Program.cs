using DSA.Basics.CircularLinkedList;
using System.Collections.Generic;

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
		case 1:
			Console.Write("Enter the number of elements: ");
			data = Convert.ToInt32(Console.ReadLine());
			List.CreateList(data);
			break;
		case 2:
			List.DisplayList();
			break;
		case 3:
			Console.Write("Enter the element to be inserted: ");
			data = Convert.ToInt32(Console.ReadLine());
			List.InsertAtBeginning(data);
			break;
		case 4:
			Console.Write("Enter the element to be inserted: ");
			data = Convert.ToInt32(Console.ReadLine());
			List.InsertAtEnd(data);
			break;
		case 5:
			Console.Write("Enter the element to be inserted: ");
			data = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the element after which to insert: ");
			info = Convert.ToInt32(Console.ReadLine());
			List.InsertAfter(data, info);
			break;
		case 6:
			List.DeleteFirstNode();
			break;
		case 7:
			List.DeleteLastNode();
			break;
		case 8:
			Console.Write("Enter the element to be deleted: ");
			data = Convert.ToInt32(Console.ReadLine());
			List.DeleteNode(data);
			break;
		case 9:
			CircularLinkedList newListForConcatenation = new CircularLinkedList();
			newListForConcatenation.CreateList(5);
			Console.WriteLine("\nFirst List - ");
			List.DisplayList();
			Console.WriteLine("\nSecond List - ");
			newListForConcatenation.DisplayList();
			Console.WriteLine("\nFinal List - ");
			List.ConcatenateList(newListForConcatenation);
			List.DisplayList();
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
	Console.WriteLine();
}
Console.WriteLine("Exiting");