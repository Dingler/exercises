using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YactClub
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberCollection members = MemberCollection.Instance;

            Member m1 = new Member("Andreas", "Istedgade 25, st. tv.", 27, 500);
            Member m2 = new Member("Per", "Snevej 1", 55, 500);
            Member m3 = new Member("Lars", "Fasanvej", 45, 500);

            Volunteer v1 = new Volunteer("Sofie", "Markvej 12", 22, 500, 250);
            Volunteer v2 = new Volunteer("Lise", "Hestemad 99", 34, 500, 90);
            Volunteer v3 = new Volunteer("Lars", "Ostevej 44", 33, 500, 100);

            Junior j1 = new Junior("Martin", "Flisevej 22", 17, 500, "Mor");
            Junior j2 = new Junior("Mads", "Markvej 1", 12, 500, "Far");
            Junior j3 = new Junior("Mikael", "Hansgade 88", 18, 500, "Bedste");

            members.AddMember(m1);
            members.AddMember(m2);
            members.AddMember(m3);

            members.AddMember(v1);
            Console.WriteLine(v1.GetFee());
            members.AddMember(v2);
            Console.WriteLine(v2.GetFee());
            members.AddMember(v3);
            Console.WriteLine(v3.GetFee());

            members.AddMember(j1);
            Console.WriteLine(j1.GetFee());
            members.AddMember(j2);
            Console.WriteLine(j2.GetFee());
            members.AddMember(j3);
            Console.WriteLine(j3.GetFee());

            Console.WriteLine("Total: " + members.GetTotalFee());
            Console.ReadLine();
        }
    }
}
