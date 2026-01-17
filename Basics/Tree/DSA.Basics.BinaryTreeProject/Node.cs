namespace DSA.Basics.BinaryTreeProject
{
    public class Node
    {
        public Node leftChild = null!;
        public int info;
        public Node rightChild = null!;

        public Node(int info)
        {
            this.info = info;
        }
    }
}