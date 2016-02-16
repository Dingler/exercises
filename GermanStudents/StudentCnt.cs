using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GermanStudents
{
    class StudentCnt
    {
        private List<Student> students;
        private static StudentCnt instance;
        private StudentCnt()
        {
            students = new List<Student>();
        }

        public static StudentCnt Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentCnt();
                }
                return instance;
            }
        }
        public void addStudent(Student s)
        {
            students.Add(s);
        }

        public string getByName(string name)
        {
            string found = "";
            foreach (Student s in students)
            {
                if (s.Name == name)
                    found = found + "Name: " + s.Name + "\r\n" + "Phone: " + s.Phone + "\r\n\r\n";
            }
            return found;
        }

        public string getByPhone(string phone)
        {
            string found = "";
            foreach (Student s in students)
            {
                if (s.Phone == phone)
                    found = found + "Name: " + s.Name + "\r\n" + "Phone: " + s.Phone + "\r\n\r\n";
            }
            return found;
        }
        public void printPassed()
        {
            string pass = "PASSED:\r\n";
            foreach (Student s in students)
            {
                if (s.passed())
                {
                    pass = pass + "Name: " + s.Name + "\r\n";
                }
            }
            Console.WriteLine(pass);
        }
        public void printFailed()
        {
            string pass = "FAILED:\r\n";
            foreach (Student s in students)
            {
                if (!s.passed())
                {
                    pass = pass + "Name: " + s.Name + "\r\n";
                }
            }
            Console.WriteLine(pass);
        }
    }

}
