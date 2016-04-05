using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GermanStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCnt cont = StudentCnt.Instance;

            LanguageMajor lStud1 = new LanguageMajor("Anders", "12345678", 2, 7);
            LanguageMajor lStud2 = new LanguageMajor("Maria", "434543", 1, 2);
            LanguageMajor lStud3 = new LanguageMajor("Lars", "534342", 3, 12);

            ScienceMajor sStud1 = new ScienceMajor("Martin", "321543", 1, 7);
            ScienceMajor sStud2 = new ScienceMajor("Per", "676556", 1, 2);
            ScienceMajor sStud3 = new ScienceMajor("Sofie", "1235232", 3, -3);

            BusinessMajor bStud1 = new BusinessMajor("Heine", "5434343154", 1, 4);
            BusinessMajor bStud2 = new BusinessMajor("Hamid", "54343254", 1, 2);
            BusinessMajor bStud3 = new BusinessMajor("Chriss", "5431112354", 1, 7);

            Student s = new BusinessMajor("der","der", 1, 5);
            cont.addStudent(s);

            cont.addStudent(lStud1);
            cont.addStudent(lStud2);
            cont.addStudent(lStud3);

            cont.addStudent(sStud1);
            cont.addStudent(sStud2);
            cont.addStudent(sStud3);

            cont.addStudent(bStud1);
            cont.addStudent(bStud2);
            cont.addStudent(bStud3);

            cont.printPassed();
            cont.printFailed();

            Console.ReadLine();
        }
    }
}
