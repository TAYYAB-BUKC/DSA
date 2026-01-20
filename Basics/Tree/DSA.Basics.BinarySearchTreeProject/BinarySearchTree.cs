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

		public void InOrder()
		{
			InOrder(root);
			Console.WriteLine();
		}

		private void InOrder(Node node)
		{
			if (node is null)
				return;

			InOrder(node.leftChild);
			Console.Write(node.info + " ");
			InOrder(node.rightChild);
		}

		public void PostOrder()
		{
			PostOrder(root);
			Console.WriteLine();
		}

		private void PostOrder(Node node)
		{
			if (node is null)
				return;

			PostOrder(node.leftChild);
			PostOrder(node.rightChild);
			Console.Write(node.info + " ");
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
			else if (info > node.info)
				node.rightChild = Insert(node.rightChild, info);
			else
				Console.WriteLine(info + " already present in tree");
			
			return node;
		}

		public bool Search(int info)
		{
			return Search(root, info) is not null;
		}

		private Node Search(Node node, int info)
		{
			if (node is null)
				return null!; /*key not found*/
			
			if (info < node.info)/*search in left subtree*/
				return Search(node.leftChild, info);
			
			if (info > node.info)/*search in right subtree*/
				return Search(node.rightChild, info);

			return node; /*key found*/
		}

		public void Delete(int info)
		{
			root = Delete(root, info);
		}

		private Node Delete(Node node, int info)
		{
			Node tempNode, tempInfo;

			if (node is null)
			{
				Console.WriteLine(info + "  not found");
				return null!;
			}

			if (info < node.info)  /*delete from left subtree*/
				node.leftChild = Delete(node.leftChild, info);
			else if (info > node.info) /*delete from right subtree*/
				node.rightChild = Delete(node.rightChild, info);
			else
			{
				/*key to be deleted is found*/
				if (node.leftChild != null && node.rightChild != null)  /*2 children*/
				{
					tempInfo = node.rightChild;
					while (tempInfo.leftChild != null)
						tempInfo = tempInfo.leftChild;
					
					node.info = tempInfo.info;
					node.rightChild = Delete(node.rightChild, tempInfo.info);
				}
				else   /*1 child or no child*/
				{
					if (node.leftChild != null) /*only left child*/
						tempNode = node.leftChild;
					else  /*only right child or no child*/
						tempNode = node.rightChild;
					
					node = tempNode;
				}
			}
			return node;
		}

		public int Min()
		{
			if (IsEmpty())
				throw new InvalidOperationException("Tree is empty");
			
			return Min(root).info;
		}

		private Node Min(Node node)
		{
			if (node.leftChild is null)
				return node;

			return Min(node.leftChild);
		}
	}
}