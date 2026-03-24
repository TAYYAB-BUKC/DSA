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

		public void DisplayTable()
		{
			for (int i = 0; i < size; i++)
			{
				Console.Write("[" + i + "]  -->  ");

				if (array[i] != null)
					array[i].DisplayList();
				else
					Console.WriteLine("___");
			}
		}

		public Student Search(int key)
		{
			int hash = GenerateHash(key);

			if (array[hash] != null)
				return array[hash].Search(key);

			return null!;
		}

		public void Insert(Student newStudent)
		{
			int key = newStudent.GetStudentId();
			int hash = GenerateHash(key);

			if (array[hash] == null)
				array[hash] = new SingleLinkedList();

			array[hash].InsertAtBeginning(newStudent);
			length++;
		}
	}
}