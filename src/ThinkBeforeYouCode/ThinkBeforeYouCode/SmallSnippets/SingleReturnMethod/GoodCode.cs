using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.ThinkBeforeYouCode.SmallSnippets.SingleReturnMethod
{
	public class GoodCode
	{
		public double ComputeTax(double income)
		{
			double tax = 0;
			if (income < 10000)
			{
				tax = income * 10f / 100f;
			}
			else if (income < 20000)
			{
				tax = income * 20f / 100f;
			}
			else
			{
				tax = income * 30f / 100f;
			}
			return tax;
		}
	}
}
