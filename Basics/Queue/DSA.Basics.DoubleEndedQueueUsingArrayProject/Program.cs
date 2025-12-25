using DSA.Basics.DoubleEndedQueueUsingArrayProject;

int choice, info;

DoubleEndedQueueUsingArray doubleEndedQueue = new(8);

while (true)
{
	Console.WriteLine("1. Insert at the front end");
	Console.WriteLine("2. Insert at the rear end");
	Console.WriteLine("3. Delete from front end");
	Console.WriteLine("4. Delete from rear end");
	Console.WriteLine("5. Display all elements of deque");
	Console.WriteLine("6. Quit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 6)
		break;

	switch (choice)
	{
		case 1:
			Console.Write("Enter the element to be inserted : ");
			info = Convert.ToInt32(Console.ReadLine());
			doubleEndedQueue.InsertFront(info);
			break;
		case 2:
			Console.Write("Enter the element to be inserted : ");
			info = Convert.ToInt32(Console.ReadLine());
			doubleEndedQueue.InsertRear(info);
			break;
		case 3:
			info = doubleEndedQueue.DeleteFront();
			if (info != -1)
				Console.WriteLine("Element deleted from front end is " + info);
			break;
		case 4:
			info = doubleEndedQueue.DeleteRear();
			if (info != -1)
				Console.WriteLine("Element deleted from rear end is  " + info);
			break;
		case 5:
			doubleEndedQueue.Display();
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
}