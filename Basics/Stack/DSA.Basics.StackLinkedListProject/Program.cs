using DSA.Basics.StackLinkedListProject;

int choice, info;

StackUsingLinkedList stack = new();

while (true)
{
	Console.WriteLine("1. Push an element on the stack");
	Console.WriteLine("2. Pop an element from the stack");
	Console.WriteLine("3. Display the top element");
	Console.WriteLine("4. Display all stack elements");
	Console.WriteLine("5. Display size of the stack");
	Console.WriteLine("6. Quit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 6)
		break;

	switch (choice)
	{
		case 1:
			Console.Write("Enter the element to be pushed : ");
			info = Convert.ToInt32(Console.ReadLine());
			stack.Push(info);
			break;
		case 2:
			info = stack.Pop();
			if (info != -1)
				Console.WriteLine("Popped element is : " + info);
			break;
		case 3:
			info = stack.Peek();
			if (info != -1)
				Console.WriteLine("Element at the top is : " + info);
			break;
		case 4:
			stack.Display();
			break;
		case 5:
			Console.WriteLine("Size of stack " + stack.Size());
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
	Console.WriteLine();
}