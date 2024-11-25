using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var regularAccount = new Account("Обычный", 1500.0);
                regularAccount.CalculateInterestAccount();
                Console.WriteLine($"Процент для обычного счета: {regularAccount.Interest}");

                var regularAccount2 = new Account("Обычный", 800);
                regularAccount2.CalculateInterestAccount();
                Console.WriteLine($"Процент для обычного счета: {regularAccount2.Interest}");

                var salaryAccount = new Account("Зарплатный", 2000);
                salaryAccount.CalculateInterestAccount();
                Console.WriteLine($"Процент для зарплатного счета: {salaryAccount.Interest}");

                var missAccount = new Account("VIP", 3000);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

    }
}
