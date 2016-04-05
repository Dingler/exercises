using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GermanStudents
{
    class BusinessMajor : Student
    {
        private int matLevel;
        private int germanGrade;

        public BusinessMajor(string name, string phone, int matLevel, int germanGrade) : base(name, phone)
        {
            this.matLevel = matLevel;
            this.germanGrade = germanGrade;
        }
        public int MatLevel
        {
            get
            {
                return matLevel;
            }
            set
            {
                matLevel = value;
            }
        }

        public int GermanGrade
        {
            get
            {
                return germanGrade;
            }
            set
            {
                germanGrade = value;
            }
        }
        public override bool passed()
        {
            bool pass = false;
            if (germanGrade >= 4)
            {
                pass = true;
            }
            return pass;
        }
    }
}
