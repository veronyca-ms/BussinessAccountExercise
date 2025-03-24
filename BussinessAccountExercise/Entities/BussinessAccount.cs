using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccountExercise.Entities
{
        class BusinessAccount : Account  //adicionando todos os atributos de Account em BussinessAccount
        {
            public double LoanLimit { get; set; }

            public BusinessAccount()
            {
            }

            public BusinessAccount(int number, string holder, double balance, double loanLimit)
                : base(number, holder, balance)
            {
                LoanLimit = loanLimit;
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
