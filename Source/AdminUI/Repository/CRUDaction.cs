
﻿using MyData;
using Entities;

namespace AdminUI.Repository
{
    public class CRUDaction
    {
        public Member GetUserById(int id)
        {
            var targetMember = DataBase.Members.FirstOrDefault(x => x.Id == id);

            if (targetMember == null)
                return null;

            return targetMember;
        }


        public void UpdateUser(Member memberForUpdate)
        {
            DataBase.Members = DataBase.LoadMembers<Member>();
            var targetMember = GetUserById(memberForUpdate.Id);

            targetMember.Name = memberForUpdate.Name;
            targetMember.LastName = memberForUpdate.LastName;
            targetMember.PhoneNumber = memberForUpdate.PhoneNumber;
            targetMember.BirthDay = memberForUpdate.BirthDay;
            targetMember.NationalCode = memberForUpdate.NationalCode;
            targetMember.Gender = memberForUpdate.Gender;
            targetMember.MemType = memberForUpdate.MemType;

            DataBase.SaveMembers(DataBase.Members);
        }


        public bool DeleteUser(int id)
        {
            if (DataBase.Members.Remove(GetUserById(id)))
            {
                DataBase.SaveMembers(DataBase.Members);
                return true;
            }
            return false;
        }
    }
}
