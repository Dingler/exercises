using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YactClub
{
    class MemberCollection
    {
        private List<Member> members;
        private static MemberCollection instance;

        private MemberCollection()
        {
            members = new List<Member>();
        }

        public static MemberCollection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberCollection();
                }
                return instance;
            }
        }

        public void addMember(Member m)
        {
            members.Add(m);
        }

        public Member findMember(string name)
        {
            foreach (Member m in members)
            {
                if (m.Name == name)
                {
                    return m;
                }
            }
            return null;
        }

        public void deleteMember(string name)
        {
            members.Remove(findMember(name));
        }

        public double getTotalFee()
        {
            double total = 0;
            foreach (Member m in members)
            {
                total = total + m.getFee();
            }
            return total;
        }
    }
}
