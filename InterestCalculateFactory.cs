using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    /// <summary>
    /// Фабрика создания калькулятора для подсчета процентной ставки
    /// </summary>

    public static class InterestCalculateFactory
    {
        private static readonly Dictionary<string, Func<ICalculateInterest>> _calculateFactories =
            new Dictionary<string, Func<ICalculateInterest>>()
            {
                { "Обычный", () => new RegularAccountInterestCalculate() },
                { "Зарплатный", () => new SalaryAccountInterestCalculate() }
            };
        public static ICalculateInterest CreateCalculator(string accountType)
        {
            if (_calculateFactories.TryGetValue(accountType, out var factory))
                return factory();
            throw new ArgumentException($"Неизвестный тип аккаунта: {accountType}", nameof(accountType));
        }
    }
}
