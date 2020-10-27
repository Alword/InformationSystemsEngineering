using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.Builder
{
	public class PgStorage : SettingsBuilder
	{
		public override string Username => "Postgres";

		public override string DatabaseName => "CloudBase";

		public override bool UseSSL => true;
	}
}
