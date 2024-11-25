using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // Свойство для реализации расчета процентной ставки
        public ICalculateInterest CalculatorInterest { get;  }

        public Account(string type, double balance)
        {
            Type = type;
            Balance = balance;
            CalculatorInterest = InterestCalculateFactory.CreateCalculator(type);
        }

        public void CalculateInterestAccount()
        {
            Interest = CalculatorInterest.CalculateInterest(Balance);
        }

    }
}
