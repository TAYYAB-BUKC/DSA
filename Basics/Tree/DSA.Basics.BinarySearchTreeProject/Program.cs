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
		case 1:
			tree.DisplayTree();
			break;
		case 2:
			Console.Write("Enter the key to be searched : ");
			info = Convert.ToInt32(Console.ReadLine());

			if (tree.Search(info))
				Console.WriteLine("Key found");
			else
				Console.WriteLine("Key not found");
			break;
		case 3:
			Console.Write("Enter the key to be inserted : ");
			info = Convert.ToInt32(Console.ReadLine());
			tree.Insert(info);
			break;
		case 4:
			Console.Write("Enter the key to be deleted : ");
			info = Convert.ToInt32(Console.ReadLine());
			tree.Delete(info);
			break;
		case 5:
			tree.PreOrder();
			break;
		case 6:
			tree.InOrder();
			break;
		case 7:
			tree.PostOrder();
			break;
		case 8:
			Console.WriteLine("Height of tree is " + tree.CalculateHeight());
			break;
		case 9:
			Console.WriteLine("Minimum key is " + tree.Min());
			break;
		case 10:
			Console.WriteLine("Maximum key is " + tree.Max());
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}
}