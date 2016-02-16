using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YactClub
{
    class Junior : Member
    {
        private string parentsName;

        public Junior(string name, string address, int age, double fee, string parentsName) : base(name, address, age, fee)
        {
            this.parentsName = parentsName;
        }
   
        public override double GetFee()
        {
            return base.GetFee()/2;
        }

        public string ParentsName
        {
            get { return parentsName; }
            set { parentsName = value; }
        }
    }
}
