using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Iterator
{
	public class Node<T>
	{
		public T Value { get; private set; }
		public List<Node<T>> Childs { get; private set; }
		public Node(T value)
		{
			this.Value = value;
			this.Childs = new List<Node<T>>();
		}
	}
}
