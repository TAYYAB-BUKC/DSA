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
            DisplayTree(root, 0);
            Console.WriteLine();
        }

        private void DisplayTree(Node node, int level)
        {
            if (node is null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            
            DisplayTree(node.rightChild, level + 1);
            Console.WriteLine();

            for (int index = 0; index < level; index++)
                Console.Write("    ");
            Console.Write(node.info);

            DisplayTree(node.leftChild, level + 1);
        }
    }
}