using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class SalaryAccountInterestCalculate : ICalculateInterest
    {
        public double CalculateInterest(double balanse)
        {
            return balanse * 0.5;
        }
    }
}
