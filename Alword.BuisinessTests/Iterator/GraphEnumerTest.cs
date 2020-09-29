using Alword.Buisiness.Iterator;
using Alword.Buisiness.Visitor;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.BuisinessTests.Iterator
{
	public class GraphEnumerTest
	{
		[Fact]
		public void TestEnumerator()
		{
			Node<int> root = new Node<int>(1);
			root.Childs.Add(new Node<int>(2));
			root.Childs.Add(new Node<int>(3));
			var node4 = new Node<int>(4);
			root.Childs.Add(node4);
			node4.Childs.Add(new Node<int>(5));
			node4.Childs.Add(new Node<int>(6));
			node4.Childs.Add(new Node<int>(7));

			IEnumer<Node<int>> graphEnumer = new Graph<int>(root);
			IIterator<Node<int>> iterator = graphEnumer.Iterator();

			List<int> acutal = new List<int>();
			while (iterator.MoveNext())
			{
				var currentNode = iterator.Current();
				acutal.Add(currentNode.Value);
			}
			int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			Assert.Equal(expected, acutal.ToArray());
		}

		[Fact]
		public void TestObserver()
		{
			List<int> actual = new List<int>();

			Node<int> root = new Node<int>(1);

			var graph = new Graph<int>(root);
			GraphSubscriber<int> sub1 = new GraphSubscriber<int>(actual);
			GraphSubscriber<int> sub2 = new GraphSubscriber<int>(actual);
			graph.Subscribe(sub1);
			graph.Subscribe(sub2);

			graph.Iterator();

			int[] expected = new int[] { 1, 1 };
			Assert.Equal(expected, actual);

		}

		class GraphSubscriber<T> : Buisiness.Observer.IMyObvserver<T>
		{
			private readonly List<T> array;
			public GraphSubscriber(List<T> array)
			{
				this.array = array;
			}
			public void Update(T state)
			{
				array.Add(state);
			}
		}
	}
}
