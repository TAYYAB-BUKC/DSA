using DSA.Basics.BinaryTreeProject;

BinaryTree binaryTree = new BinaryTree();

binaryTree.CreateDummyTree();

binaryTree.DisplayTree();
Console.WriteLine();

Console.WriteLine("Preorder : ");
binaryTree.PreOrder();
Console.WriteLine("");

Console.WriteLine("Inorder : ");
binaryTree.InOrder();
Console.WriteLine();

Console.WriteLine("Postorder : ");
binaryTree.PostOrder();
Console.WriteLine();

Console.WriteLine("Level order : ");
binaryTree.LevelOrder();
Console.WriteLine();

Console.ReadKey();