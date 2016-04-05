using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
	public class BankAccount
	{
		private int accNo;
		private double interestRate;
		private double balance;

        public BankAccount(int no, double ir, double bal)
		{
			this.accNo= no;
			this.balance= bal;
			this.interestRate= ir;
		}

		public virtual bool Withdraw(double amount)
		{
			bool ok = false;
			if(balance>=amount)
			{
                balance = balance - amount;
				ok = true;
			}
			return ok;
		}

		public bool Deposite(double amount)
		{
			bool ok = false;
			if(amount>0)
			{
                balance = balance + amount;
				ok=true;
			}
			return ok;
		}

		public double Balance
		{
			get{return balance;}

		}

        public virtual double Disposable
        {
            get { return balance; }
        }

	}

}
