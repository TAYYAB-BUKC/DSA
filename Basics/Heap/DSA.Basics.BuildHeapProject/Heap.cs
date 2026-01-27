namespace DSA.Basics.BuildHeapProject
{
	public class Heap
	{
		private static void RestoreUp(int size, int[] heap)
		{
			int value = heap[size];
			int parentIndex = size / 2;

			while (heap[parentIndex] < value)
			{
				heap[size] = heap[parentIndex];
				size = parentIndex;
				parentIndex = size / 2;
			}
			heap[size] = value;
		}

		public static void BuildHeap_TopDown(int[] heap, int size)
		{
			for (int index = 2; index <= size; index++)
				RestoreUp(index, heap);
		}

		private static void RestoreDown(int index, int[] heap, int size)
		{
			int value = heap[index];
			int leftChild = 2 * index, rightChild = leftChild + 1;

			while (rightChild <= size)
			{
				if (value >= heap[leftChild] && value >= heap[rightChild])
				{
					heap[index] = value;
					return;
				}
				else if (heap[leftChild] > heap[rightChild])
				{
					heap[index] = heap[leftChild];
					index = leftChild;
				}
				else
				{
					heap[index] = heap[rightChild];
					index = rightChild;
				}
				leftChild = 2 * index;
				rightChild = leftChild + 1;
			}

			if (leftChild == size && value < heap[leftChild])
			{
				heap[index] = heap[leftChild];
				index = leftChild;
			}
			heap[index] = value;
		}

		public static void BuildHeap_BottomUp(int[] heap, int size)
		{
			for (int index = size / 2; index >= 1; index--)
				RestoreDown(index, heap, size);
		}
	}
}