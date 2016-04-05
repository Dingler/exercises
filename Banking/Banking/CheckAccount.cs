using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class CheckAccount:BankAccount
    {
        private double fee;
        private double limit;

        public CheckAccount(int no, double ir, double bal, double fee, double limit) : base(no, ir, bal)
        {
            this.fee = fee;
            this.limit = limit;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount+fee);
        }

        public override double Disposable
        {
            get
            {
                return base.Disposable+limit;
            }
        }
    }

}
