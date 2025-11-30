using DSA.Basics.SingleLinkedList;
using System.Xml.Linq;

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
	Console.WriteLine("16. Merge two sorted lists by arranging links");
	Console.WriteLine("17. Sort by using recursive Merge Sort");
	Console.WriteLine("18. Detect Cycle");
	Console.WriteLine("19. Insert Cycle");
	Console.WriteLine("20. Remove Cycle");
	Console.WriteLine("21. Concatenate List");
	Console.WriteLine("22. Quit");

	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 22)
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
			Console.WriteLine("\nFirst List - ");
			list.DisplayList();
			Console.WriteLine("\nSecond List - ");
			secondList.DisplayList();
			Console.WriteLine("\nMerged List - ");
			newList.DisplayList();
			break;
		case 16:
			SingleLinkedList secondListMerge = new SingleLinkedList();
			SingleLinkedList newListMerge = new SingleLinkedList();
			list.SortListByExchangingDataUsingBubbleSort();
			secondListMerge.CreateList(5);
			secondListMerge.SortListByExchangingDataUsingBubbleSort();
			newListMerge = list.MergeByArrangingLinks(secondListMerge);
			Console.WriteLine("\nFirst List - ");
			list.DisplayList();
			Console.WriteLine("\nSecond List - ");
			secondListMerge.DisplayList();
			Console.WriteLine("\nMerged List - ");
			newListMerge.DisplayList();
			break;
		case 17:
			SingleLinkedList newListForMergeSort = new SingleLinkedList();
			newListForMergeSort.CreateList(10);
			Console.WriteLine("\nUnsorted List - ");
			newListForMergeSort.DisplayList();
			newListForMergeSort.SortListByUsingRecursiveMergeSort();
			Console.WriteLine("\nSorted Merged List - ");
			newListForMergeSort.DisplayList();
			break;
		case 18:
			if (list.HasCycle())
			{
				Console.WriteLine("List does contain a cycle");
			}
			else
			{
				Console.WriteLine("List does not contain a cycle");
			}
			break;
		case 19:
			Console.Write("Enter the element where the cycle needs to be inserted : ");
			data = Convert.ToInt32(Console.ReadLine());
			list.InsertCycle(data);
			break;
		case 20:
			list.RemoveCycle();
			break;
		case 21:
			SingleLinkedList newListForConcatenation = new SingleLinkedList();
			newListForConcatenation.CreateList(5);
			Console.WriteLine("\nFirst List - ");
			list.DisplayList();
			Console.WriteLine("\nSecond List - ");
			newListForConcatenation.DisplayList();
			Console.WriteLine("\nFinal List - ");
			list.ConcatenateList(newListForConcatenation);
			list.DisplayList();
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
	Console.WriteLine();
}

Console.WriteLine("Exiting");