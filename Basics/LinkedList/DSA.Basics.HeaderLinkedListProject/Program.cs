using DSA.Basics.HeaderLinkedListProject;

int choice, data, info, position;

HeaderLinkedList List = new HeaderLinkedList();

while (true)
{
	Console.WriteLine("0. Create list"); 
	Console.WriteLine("1. Display list");
	Console.WriteLine("2. Insert a node at the end of the list");
	Console.WriteLine("3. Insert a new node before a node");
	Console.WriteLine("4. Insert at a given position");
	Console.WriteLine("5. Delete a node");
	Console.WriteLine("6. Reverse the list");
	Console.WriteLine("7. Quit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 7)
		break;

	switch (choice)
	{
		
	}
}