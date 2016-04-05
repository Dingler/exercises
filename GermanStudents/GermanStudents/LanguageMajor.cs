using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GermanStudents
{
    class LanguageMajor : Student
    {
        private int noOfLang;
        private int germanGrade;

        public LanguageMajor(string name, string phone, int noOfLang, int germanGrade) : base(name, phone)
        {
            this.noOfLang = noOfLang;
            this.germanGrade = germanGrade;
        }
        public int NoOfLang
        {
            get
            {
                return noOfLang;
            }
            set
            {
                noOfLang = value;
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
            if (germanGrade >= 7)
            {
                pass = true;
            }
            return pass;
        }

    }
}
