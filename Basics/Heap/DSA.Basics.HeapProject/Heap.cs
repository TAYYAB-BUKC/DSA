namespace DSA.Basics.HeapProject
{
	public class Heap
	{
		private int[] heap;
		private int size;

		public Heap()
		{
			heap = new int[10];
			size = 0;
			heap[0] = 99999;
		}

		public Heap(int maxSize)
		{
			heap = new int[maxSize];
			size = 0;
			heap[0] = 99999;
		}

		public void Insert(int value)
		{
			size++;
			heap[size] = value;
			RestoreUp(size);
		}

		private void RestoreUp(int size)
		{
			int value = heap[size];
			int parentIndex = size / 2;

			while (heap[parentIndex] < value) /*No sentinel - while(iparent>=1 && heap[iparent]<value)*/
			{
				heap[size] = heap[parentIndex];
				size = parentIndex;
				parentIndex = size / 2;
			}
			heap[size] = value;
		}
	}
}
