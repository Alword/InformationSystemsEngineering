using Alword.Buisiness.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Iterator
{
	public interface IEnumer<T>
	{
		IIterator<T> Iterator();
	}
}
