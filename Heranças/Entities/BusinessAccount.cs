using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimite { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double LoanLimite) : base(number, holder, balance)
        {
            LoanLimite = LoanLimite;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimite)
            Balance += LoanLimite;
        }
    }
}
