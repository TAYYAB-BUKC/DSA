using DSA.Basics.SortedLinkedListProject;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

int choice, info;

SortedLinkedList list = new SortedLinkedList();

while (true)
{
	Console.WriteLine("0. Create List");
	Console.WriteLine("1. Display List");
	Console.WriteLine("2. Insert a new node");
	Console.WriteLine("3. Search");
	Console.WriteLine("4. Exit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());
	if (choice == 4)
		break;

	switch (choice)
	{
		case 0:
			Console.WriteLine("Enter the number of elements to be inserted : ");
			info = Convert.ToInt32(Console.ReadLine());
			list.CreateList(info);
			break;
		case 1:
			list.DisplayList();
			break;
		case 2:
			Console.WriteLine("Enter the element to be inserted : ");
			info = Convert.ToInt32(Console.ReadLine());
			list.InsertInOrder(info);
			break;
		case 3:
			Console.WriteLine("Enter the element to be searched : ");
			info = Convert.ToInt32(Console.ReadLine());
			list.Search(info);
			break;
		default:
			Console.WriteLine("Wrong choice\n");
			break;
	}
}