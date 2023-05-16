using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public String Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() 
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposito(double amount)
        {
            Balance += amount;
        }
    }
}
