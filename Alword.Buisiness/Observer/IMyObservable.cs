using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Observer
{
	public interface IMyObservable<T>
	{
		void Subscribe(IMyObvserver<T> observer);
		void Unsubcribe(IMyObvserver<T> observer);
		void Notify(T s);
	}
}
