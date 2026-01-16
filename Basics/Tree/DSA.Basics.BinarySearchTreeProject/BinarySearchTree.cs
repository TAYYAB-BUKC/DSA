namespace DSA.Basics.BinarySearchTreeProject
{
	public class BinarySearchTree
	{
		private Node root = null!;

		public bool IsEmpty()
		{
			return root is null;
		}

		public int CalculateHeight()
		{
			return CalculateHeight(root);
		}

		private int CalculateHeight(Node node)
		{
			if (node is null)
				return 0;

			int leftHeight = CalculateHeight(node.leftChild);
			int rightHeight = CalculateHeight(node.rightChild);

			if (leftHeight > rightHeight)
				return 1 + leftHeight;
			else
				return 1 + rightHeight;
		}

		public void DisplayTree()
		{
			if (root is null)
				Console.WriteLine("Tree is empty");
			else
				DisplayTree(root, 0);
			Console.WriteLine();
		}

		private void DisplayTree(Node node, int level)
		{
			if (node is null)
			{
				return;
			}

			DisplayTree(node.rightChild, level + 1);
			Console.WriteLine();

			for (int index = 0; index < level; index++)
				Console.Write("    ");
			Console.Write(node.info);

			DisplayTree(node.leftChild, level + 1);
		}

		public void PreOrder()
		{
			PreOrder(root);
			Console.WriteLine();
		}

		private void PreOrder(Node node)
		{
			if (node is null)
				return;

			Console.Write(node.info + " ");
			PreOrder(node.leftChild);
			PreOrder(node.rightChild);
		}
	}
}