using DSA.Basics.StackLinkedListProject;

int choice, info;

Stack stack = new();

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
		
	}
	Console.WriteLine();
}
