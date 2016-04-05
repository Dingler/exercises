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

        public void AddMember(Member m)
        {
            members.Add(m);
        }

        public Member FindMember(string name)
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

        public void DeleteMember(string name)
        {
            members.Remove(FindMember(name));
        }

        public double GetTotalFee()
        {
            double total = 0;
            foreach (Member m in members)
            {
                total = total + m.GetFee();
            }
            return total;
        }
    }
}
