using DSA.Basics.PriorityQueueUsingLinkedListProject;

int choice, element, elementPriority;

PriorityQueueUsingLinkedList priorityQueueUsingLinkedList = new();

while (true)
{
	Console.WriteLine("1. Insert a new element");
	Console.WriteLine("2. Delete an element");
	Console.WriteLine("3. Display the queue");
	Console.WriteLine("4. Quit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());
	if (choice == 4)
		break;

	switch (choice)
	{
		case 1:
			Console.WriteLine("Enter the element to be inserted : ");
			element = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter its priority : ");
			elementPriority = Convert.ToInt32(Console.ReadLine());
			priorityQueueUsingLinkedList.Insert(element, elementPriority);
			break;
		case 2:
			element = priorityQueueUsingLinkedList.Delete();
			if (element != -1)
				Console.WriteLine("Deleted element is : " + element);
			break;
		case 3:
			priorityQueueUsingLinkedList.Display();
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
}