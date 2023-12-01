using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount() { }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double balance)
        { 
            Balance += Balance * InterestRate; 
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount); // Executa a classe normal
            Balance -= 2.0; // Após faz mais alguma operação
        }
    }
}
