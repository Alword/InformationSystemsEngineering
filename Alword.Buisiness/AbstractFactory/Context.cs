using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.AbstractFactory
{
	public struct Context
	{
		public string connectionString;
		public string connectionAttributes;

		public override bool Equals(object obj)
		{
			return obj is Context context &&
				   connectionString == context.connectionString &&
				   connectionAttributes == context.connectionAttributes;
		}

		public override int GetHashCode()
		{
			var hashCode = -1553800492;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(connectionString);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(connectionAttributes);
			return hashCode;
		}
	}
}
