using Alword.Buisiness.Observer;
using Alword.Buisiness.Visitor;
using System;
using System.Collections.Generic;

namespace Alword.Buisiness.Iterator
{
	// класс-рассылка
	// Array<IEnumer<Node<T>>> array

	public class Graph<T> : IEnumer<Node<T>>, IMyObservable<T>
	{
		public Graph(Node<T> node)
		{
			this.Root = node;
		}
		private List<IMyObvserver<T>> observers = new List<IMyObvserver<T>>();
		public Node<T> Root { get; private set; }

		public IIterator<Node<T>> Iterator()
		{
			Notify(Root.Value);
			return new GraphDepthIterator<T>(this);
		}

		public void Subscribe(IMyObvserver<T> observer)
		{
			observers.Add(observer);
		}

		public void Unsubcribe(IMyObvserver<T> observer)
		{
			throw new NotImplementedException();
		}

		public void Notify(T s)
		{
			foreach (var x in observers)
			{
				x.Update(s);
			}
		}
	}
}