namespace DSA.Basics.RadixSort
{
	public class RadixSort
	{
		/*Returns number of digits in the largest element of the list */
		public static int DigitsInLargest(Node start)
		{
			/*Find largest element*/
			int large = 0;
			Node node = start;
			while (node != null)
			{
				if (node.info > large)
					large = node.info;
				node = node.link;
			}

			/*Find number of digits in largest element*/
			int ndigits = 0;
			while (large != 0)
			{
				ndigits++;
				large /= 10;
			}
			return ndigits;
		}

		/*Returns kth digit from right in the number*/
		public static int Digit(int info, int postition)
		{
			int digit = 0, index;
			for (index = 1; index <= postition; index++)
			{
				digit = info % 10;
				info /= 10;
			}
			return digit;
		}

		public static Node Sort(Node start, int length)
		{
			Node[] rear = new Node[length];
			Node[] front = new Node[length];

			int leastSigPos = 1;
			int mostSigPos = DigitsInLargest(start);

			int index, dig;
			Node node;
			for (int k = leastSigPos; k <= mostSigPos; k++)
			{
				/*Making all the queues empty at the beginning of each pass*/
				for (index = 0; index <= length; index++)
				{
					rear[index] = null!;
					front[index] = null!;
				}

				for (node = start; node != null; node = node.link)
				{
					/*Find kth digit from right in the number*/
					dig = Digit(node.info, k);

					/*Insert the node in Queue(dig) */
					if (front[dig] == null)
						front[dig] = node;
					else
						rear[dig].link = node;
					rear[dig] = node;
				}

				/*Join all queues to form new linked list*/
				index = 0;
				while (front[index] == null)  /*Finding first non empty queue*/
					index++;
				start = front[index];
				while (index <= length - 2)
				{
					if (rear[index + 1] != null) /*if (index+1)th  queue is not empty*/
						rear[index].link = front[index + 1]; /*join end of ith queue to start of (index+1)th queue*/
					else
						rear[index + 1] = rear[index]; /*continue with rear[index]*/
					index++;
				}
				rear[length - 1].link = null!;
			}
			return start;
		}
	}
}
