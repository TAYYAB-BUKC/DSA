namespace DSA.Basics.BinaryTreeProject
{
    public class BinaryTree
    {
        private Node root = null!;

        public void CreateDummyTree()
        {
            root = new Node('P');
            root.leftChild = new Node('Q');
            root.rightChild = new Node('R');
            root.leftChild.leftChild = new Node('A');
            root.leftChild.rightChild = new Node('B');
            root.rightChild.leftChild = new Node('X');
        }

        public void DisplayTree()
        {
            if(root is null)
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

		public void LevelOrder()
		{
			if (root is null)
			{
				Console.WriteLine("Tree is empty");
				return;
			}

			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			Node node;
			while (queue.Count != 0)
			{
				node = queue.Dequeue();
				Console.Write(node.info + " ");

				if (node.leftChild != null)
					queue.Enqueue(node.leftChild);
				
				if (node.rightChild != null)
					queue.Enqueue(node.rightChild);
			}
			Console.WriteLine();
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
			if (node == null)
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

		private void PostOrder(Node p)
		{
			if (p is null)
				return;

			PostOrder(p.leftChild);
			PostOrder(p.rightChild);
			Console.Write(p.info + " ");
		}
	}
}