using System;
using System.Collections.Generic;

namespace aula108.Entites
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double LoanLimit) : base(number, holder, balance)
        {
            LoanLimit = LoanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
