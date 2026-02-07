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
	}
}