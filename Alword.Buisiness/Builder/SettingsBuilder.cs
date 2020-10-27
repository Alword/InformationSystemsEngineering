using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Builder
{
	public abstract class SettingsBuilder
	{
		public abstract string Username { get; }
		public abstract string DatabaseName { get; }
		public abstract bool UseSSL { get; }
		public virtual string BuildConnectionString()
		{
			return UseSSL ? $"https:/{Username}/{DatabaseName}"
				: $"http/{Username}/{DatabaseName}";
		}
	}
}
