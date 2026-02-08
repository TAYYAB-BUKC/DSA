namespace DSA.Basics.BinaryTreeSort
{
	public class BinaryTreeSort
	{
		private Node root = null!;
		private static int k;

		public bool IsEmpty()
		{
			return root is null;
		}

		public void InOrder(int[] array)
		{
			k = 0;
			InOrder(root, array);
		}

		private void InOrder(Node node, int[] array)
		{
			if (node is null)
				return;

			InOrder(node.leftChild, array);
			array[k++] = node.info;
			InOrder(node.rightChild, array);
		}

		public void Insert(int info)
		{
			root = Insert(root, info);
		}

		private Node Insert(Node node, int info)
		{
			if (node == null)
				node = new Node(info);
			else if (info < node.info)
				node.leftChild = Insert(node.leftChild, info);
			else
				node.rightChild = Insert(node.rightChild, info);

			return node;
		}

		public static void Sort(int[] array, int length)
		{
			BinaryTreeSort tree = new BinaryTreeSort();

			for (int i = 0; i < length; i++)
				tree.Insert(array[i]);

			tree.InOrder(array);
		}
	}
}