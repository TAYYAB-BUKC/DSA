// See https://aka.ms/new-console-template for more information
using DSA.Basics.CircularLinkedList;

Console.WriteLine("Hello, World!");

CircularLinkedList list = new CircularLinkedList();

list.CreateList(5);
list.InsertAtBeginning(5);
//list.InsertAtBeginning(15);
//list.InsertAtBeginning(15);
//list.InsertAtBeginning(20);
//list.InsertAtBeginning(25);
//list.InsertAtBeginning(30);
list.InsertAtEnd(35);
list.InsertAtEnd(40);
list.InsertAfter(40, 100);
list.InsertAtEnd(1000);
list.DisplayList();
list.DeleteFirstNode();
Console.WriteLine("After Deleting First Node");
list.DisplayList();
list.DeleteLastNode();
Console.WriteLine("After Deleting Last Node");
list.DisplayList();
list.DeleteNode(35);
Console.WriteLine("After Deleting Node");
list.DisplayList();


Console.ReadKey();