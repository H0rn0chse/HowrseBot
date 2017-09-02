using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.WebClient
{
	public sealed class HTMLConverter
	{
		private static readonly HTMLConverter instance = new HTMLConverter();

		private HTMLConverter() { }

		public static HTMLConverter Instance
		{
			get
			{
				return instance;
			}
		}
	}
}
