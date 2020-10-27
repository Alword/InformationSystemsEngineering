using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Builder
{
	public class InMemoryStorage : SettingsBuilder
	{
		public override string Username => "InMemory";

		public override string DatabaseName => "TestDatabase";

		public override bool UseSSL => false;

		public override string BuildConnectionString()
		{
			return $"{UseSSL}:{Username}:{DatabaseName}";
		}
	}
}
