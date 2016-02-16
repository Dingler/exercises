using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YactClub
{
    class Member
    {
        private string name;
        private string address;
        private int age;
        private double fee;

        public Member(string name, string address, int age, double fee)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.fee = fee;
        }

        public virtual double GetFee()
        {
            return fee;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value;}
        }

        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }
    }
}
