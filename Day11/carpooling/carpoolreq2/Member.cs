using System.Collections.Generic;

namespace carpoolreq2
{
    internal class Member
    {

        internal static  Member FindMember(long id, List<Member> members)
        {
            foreach (Member member in members)
            {
                if (member.Id == id)
                {
                    return member;

                }
            }
            return null;
        } }
}
