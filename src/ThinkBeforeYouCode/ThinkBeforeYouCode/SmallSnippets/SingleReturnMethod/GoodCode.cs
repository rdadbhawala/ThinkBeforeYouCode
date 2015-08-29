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
				tax = income * 10d / 100d;
			}
			else if (income < 20000)
			{
				tax = income * 20d / 100d;
			}
			else
			{
				tax = income * 30d / 100d;
			}
			return tax;
		}
	}

	public class GoodCodeDone
	{
		public double ComputeTax(double income)
		{
			double tax = 0;
			if (income < 10000)
			{
				tax = income * 10d / 100d;
			}
			else if (income < 20000)
			{
				tax = income * 20d / 100d;
			}
			else
			{
				tax = income * 30d / 100d;
			}
			tax += (tax * 10d / 100d);
			return tax;
		}
	}
}
