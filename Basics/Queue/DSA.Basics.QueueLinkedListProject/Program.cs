using DSA.Basics.QueueLinkedListProject;

int choice, info;

Queue queue = new Queue();

while (true)
{
	Console.WriteLine("1. Insert an element in the queue");
	Console.WriteLine("2. Delete an element from the queue");
	Console.WriteLine("3. Display element at the front");
	Console.WriteLine("4. Display all elements of the queue");
	Console.WriteLine("5. Display size of the queue");
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