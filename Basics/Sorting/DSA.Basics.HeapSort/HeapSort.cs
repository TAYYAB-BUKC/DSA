namespace DSA.Basics.HeapSort
{
	public class HeapSort
	{
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
	}
}