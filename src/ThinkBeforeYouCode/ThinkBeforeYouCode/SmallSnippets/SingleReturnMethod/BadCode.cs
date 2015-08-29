using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.ThinkBeforeYouCode.SmallSnippets.SingleReturnMethod
{
	public class BadCode
	{
		public double ComputeTax(double income)
		{
			if (income < 10000)
			{
				return income * 10d / 100d;
			}
			else if (income < 20000)
			{
				return income * 20d / 100d;
			}
			else
			{
				return income * 30d / 100d;
			}
		}
	}

	public class BadCodeNewMethod
	{
		public double ComputeTax(double income)
		{
			return ComputeTaxOld(income) * 10d/100d;
		}

		private static double ComputeTaxOld(double income)
		{
			if (income < 10000)
			{
				return income * 10d / 100d;
			}
			else if (income < 20000)
			{
				return income * 20d / 100d;
			}
			else
			{
				return income * 30d / 100d;
			}
		}
	}

	public class BadCodeExtendParent
	{
		public virtual double ComputeTax(double income)
		{
			if (income < 10000)
			{
				return income * 10d / 100d;
			}
			else if (income < 20000)
			{
				return income * 20d / 100d;
			}
			else
			{
				return income * 30d / 100d;
			}
		}
	}

	public class BadCodeExtendChild
		: BadCodeExtendParent
	{
		public override double ComputeTax(double income)
		{
			return (base.ComputeTax(income) * 110f / 100f);
		}
	}
}
