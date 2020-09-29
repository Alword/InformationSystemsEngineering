using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Observer
{
	public interface IMyObvserver<T>
	{
		void Update(T state);
	}
}
