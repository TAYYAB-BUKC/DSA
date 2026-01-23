using DSA.Basics.BinarySearchTreeProject;

BinarySearchTree tree = new();
int choice, info;

while (true)
{
	Console.WriteLine("1. Display Tree");
	Console.WriteLine("2. Search");
	Console.WriteLine("3. Insert a new node");
	Console.WriteLine("4. Delete a node");
	Console.WriteLine("5. Preorder Traversal");
	Console.WriteLine("6. Inorder Traversal");
	Console.WriteLine("7. Postorder Traversal");
	Console.WriteLine("8. Height of tree");
	Console.WriteLine("9. Find Minimum key");
	Console.WriteLine("10. Find Maximum key");
	Console.WriteLine("11. Quit");
	Console.Write("Enter your choice : ");
	choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 11)
		break;

	switch (choice)
	{
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
}