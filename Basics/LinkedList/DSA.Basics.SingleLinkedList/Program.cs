using DSA.Basics.SingleLinkedList;

int choice, data, position, info;

SingleLinkedList list = new SingleLinkedList();

list.CreateList(5);

while (true)
{
	Console.WriteLine("1. Display list");
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
	Console.WriteLine("13. Quit");

	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Exiting");
	Console.ReadKey();
}