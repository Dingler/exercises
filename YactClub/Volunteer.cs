using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YactClub
{
    class Volunteer : Member
    {
        public Volunteer(string name, string address, int age, double fee, int hours) : base(name, address, age, fee)
        {
            this.Hours = hours;
        }

        public override double GetFee()
        {
            if (Hours >= 100)
            {
                return base.GetFee() - base.GetFee();
            }
            return base.GetFee() * 0.75;

        }

        public int Hours { get; set; }
    }
}
