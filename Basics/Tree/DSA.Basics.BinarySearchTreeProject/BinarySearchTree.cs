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

		public int Max()
		{
			if (IsEmpty())
				throw new InvalidOperationException("Tree is empty");
			
			return Max(root).info;
		}

		private Node Max(Node node)
		{
			if (node.rightChild is null)
				return node;

			return Max(node.rightChild);
		}

		public int MinWithoutRecursion()
		{
			if (IsEmpty())
				throw new InvalidOperationException("Tree is empty");
			
			Node node = root;
			while (node.leftChild != null)
				node = node.leftChild;

			return node.info;
		}

		public int MaxWithoutRecursion()
		{
			if (IsEmpty())
				throw new InvalidOperationException("Tree is empty");

			Node node = root;
			while (node.rightChild != null)
				node = node.rightChild;

			return node.info;
		}

		public void InsertWithoutRecursion(int info)
		{
			Node root = this.root;
			Node node = null!;

			while (root != null)
			{
				node = root;
				if (info < root.info)
					root = root.leftChild;
				else if (info > root.info)
					root = root.rightChild;
				else
				{
					Console.WriteLine(info + " already present in the tree");
					return;
				}
			}

			Node temp = new Node(info);

			if (node == null)
				this.root = temp;
			else if (info < node.info)
				node.leftChild = temp;
			else
				node.rightChild = temp;
		}

		public bool SearchWithoutRecursion(int info)
		{
			Node node = root;
			while (node != null)
			{
				if (info < node.info)
					node = node.leftChild; /*Move to left child*/
				else if (info > node.info)
					node = node.rightChild;  /*Move to right child */
				else    /*info found*/
					return true;
			}
			return false;
		}

		public void DeleteWithoutRecursion(int info)
		{
			Node root = this.root;
			Node node = null!;

			while (root != null)
			{
				if (info == root.info)
					break;
				node = root;
				if (info < root.info)
					root = root.leftChild;
				else
					root = root.rightChild;
			}

			if (root == null)
			{
				Console.WriteLine(info + " not found");
				return;
			}

			/*Case C: 2 children*/
			/*Find inorder successor and its parent*/
			Node s, ps;
			if (root.leftChild != null && root.rightChild != null)
			{
				ps = root;
				s = root.rightChild;

				while (s.leftChild != null)
				{
					ps = s;
					s = s.leftChild;
				}
				root.info = s.info;
				root = s;
				node = ps;
			}

			/*Case B and Case A : 1 or no child*/
			Node ch;
			if (root.leftChild != null) /*node to be deleted has left child */
				ch = root.leftChild;
			else                /*node to be deleted has right child or no child*/
				ch = root.rightChild;

			if (node == null)   /*node to be deleted is root node*/
				this.root = ch;
			else if (root == node.leftChild)/*node is left child of its parent*/
				node.leftChild = ch;
			else       /*node is right child of its parent*/
				node.rightChild = ch;
		}
	}
}