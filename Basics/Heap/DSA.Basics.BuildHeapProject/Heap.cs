namespace DSA.Basics.BuildHeapProject
{
	public class Heap
	{
		private void RestoreUp(int size, int[] heap)
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
	}
}