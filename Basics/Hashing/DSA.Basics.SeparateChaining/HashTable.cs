namespace DSA.Basics.SeparateChaining
{
	public class HashTable
	{
		private SingleLinkedList[] array;
		private int size;
		private int length;

		public HashTable() : this(11)
		{
		}

		public HashTable(int tableSize)
		{
			size = tableSize;
			length = 0;
			array = new SingleLinkedList[tableSize];
		}

		private int GenerateHash(int key)
		{
			return (key % size);
		}
	}
}