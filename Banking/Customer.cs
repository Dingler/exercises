using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
	public class Customer
	{
		private int custNo;
		private string name;
		private List<BankAccount> accounts;

		public Customer(int cNo, string n)
		{
			this.custNo= cNo;
			this.name= n;
            accounts = new List<BankAccount>();
		}

		public void AddAccount(BankAccount acc)
		{
			accounts.Add(acc);
		}

		public double GetTotalBalance()
		{
			double sum = 0;
			for(int i=0; i<accounts.Count; i++)
			{
				sum = sum + accounts[i].Balance;
			}
			return sum;
		}

        public double GetTotalDispose()
        {
            double sum = 0;
            foreach (BankAccount ba in accounts){
                sum = sum + ba.Disposable;
            }
            return sum;
        }


	}

}
