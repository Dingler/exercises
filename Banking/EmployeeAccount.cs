using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class EmployeeAccount:CheckAccount
    {
        private double fee;
        private double limit;
        public EmployeeAccount(int no, double ir, double bal, double fee, double limit) : base(no, ir, bal, fee, limit)
        {
            this.fee = fee;
            this.limit = limit;
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount-fee);
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
