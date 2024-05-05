using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTest
{
	internal static class ExtensionMethods
	{
		public static int Add(this int firstArg, int seconcdArg)
		{ 
			return firstArg + seconcdArg;
		}

	}
}
