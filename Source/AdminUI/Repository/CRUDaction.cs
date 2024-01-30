using Data;
using Entities;

namespace AdminUI.Repository
{
    public class CRUDaction
    {
        public Member GetUserById(int id)
        {
            return DataBase.Members.FirstOrDefault(x => x.Id == id);
        }


        public void UpdateUser(Member memberForUpdate)
        {
            var targetMember = GetUserById(memberForUpdate.Id);
            targetMember.Name = memberForUpdate.Name;
            targetMember.LastName = memberForUpdate.LastName;
            targetMember.PhoneNumber = memberForUpdate.PhoneNumber;
            targetMember.BirthDay = memberForUpdate.BirthDay;
            targetMember.NationalCode = memberForUpdate.NationalCode;
            targetMember.Gender = memberForUpdate.Gender;
            targetMember.MemType = memberForUpdate.MemType;
        }


        public void DeleteUser(int id)
        {
            DataBase.Members.Remove(GetUserById(id));
        }
    }
}
