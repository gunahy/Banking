using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class RegularAccountInterestCalculate : ICalculateInterest
    {
        public double CalculateInterest(double balanse)
        {
            double Interest = balanse * 0.4;
            if (balanse < 1000) Interest -= balanse * 0.2;
            else Interest -= balanse * 0.4;
            return Interest;    
        }
    }
}
