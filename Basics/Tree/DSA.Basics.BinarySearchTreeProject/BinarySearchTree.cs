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
	}
}