using Alword.Buisiness.Iterator;
using Alword.Buisiness.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alword.Buisiness.Visitor
{
	public class GraphDepthIterator<T> : IIterator<Node<T>>
	{
		private readonly Queue<Node<T>> queue;
		private Node<T> current;
		public GraphDepthIterator(Graph<T> graph)
		{
			current = graph.Root;
			queue = new Queue<Node<T>>();
			queue.Enqueue(current);
		}
		public Node<T> Current() => current;

		public bool MoveNext()
		{
			if (queue.Any())
			{
				current = queue.Dequeue();
				foreach (var x in current.Childs)
				{
					queue.Enqueue(x);
				}
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}
	}
}
