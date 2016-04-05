using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GermanStudents
{
    abstract class Student
    {
        private string name;
        private string phone;

        public Student(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public abstract bool passed();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }


    }


}
