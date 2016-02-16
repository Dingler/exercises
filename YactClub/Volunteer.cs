using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YactClub
{
    class Volunteer : Member
    {
        private int hours;

        public Volunteer(string name, string address, int age, double fee, int hours) : base(name, address, age, fee)
        {
            this.hours = hours;
        }

        public override double getFee()
        {
            if (hours >= 100)
            {
                return base.getFee() - base.getFee();
            }
            return base.getFee() * 0.75;

        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
    }
}
