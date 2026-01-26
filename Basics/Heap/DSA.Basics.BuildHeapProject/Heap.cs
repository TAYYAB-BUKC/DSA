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
	}
}