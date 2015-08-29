using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.ThinkBeforeYouCode.SmallSnippets.SingleReturnMethod
{
	public class BadCode
	{
		public BadCode()
		{ }

		public double ComputeTax(double income)
		{
			if (income < 10000)
			{
				return income * 10f / 100f;
			}
			else if (income < 20000)
			{
				return income * 20f / 100f;
			}
			else
			{
				return income * 30f / 100f;
			}
		}
	}
}
