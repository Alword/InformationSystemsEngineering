using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Visitor
{
	public interface IIterator<T> 
	{
        T Current();

        bool MoveNext();

        void Reset();
    }
}
