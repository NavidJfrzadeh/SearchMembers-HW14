using Data;
using Entities;

namespace AdminUI.Repository
{
    public class Search
    {
        public List<Member> GetMembers(MemberModel memberModel)
        {
            List<Member> members = new List<Member>();

            if (memberModel.Name != null && memberModel.LastName != null)
            {
                members = DataBase.Members.Where(x => x.Name.Contains(memberModel.Name) && x.LastName.Contains(memberModel.LastName)).ToList();
            }

            else if (memberModel.Name != null)
            {
                members = DataBase.Members.Where(x => x.Name.Contains(memberModel.Name)).ToList();
            }

            else if (memberModel.LastName != null)
            {
                members = DataBase.Members.Where(x => x.LastName.Contains(memberModel.LastName)).ToList();
            }

            return members;
        }

    }
}