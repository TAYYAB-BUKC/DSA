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
    }
}