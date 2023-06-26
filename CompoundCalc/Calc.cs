using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundCalc
{
    public class Calc
    {
        public static decimal CompoundCalc(decimal initialFund,float Interest,int Period)
        {
            var MonthlyFund = new decimal[Period + 1];
            MonthlyFund[0] = initialFund;
            for (int i = 1; i <= Period; i++)
            {
                MonthlyFund[i] = MonthlyFund[i - 1] + decimal.Parse((float.Parse(MonthlyFund[i - 1].ToString()) * Interest).ToString()); 
            }
            return MonthlyFund.Last();
        }
    }
}
