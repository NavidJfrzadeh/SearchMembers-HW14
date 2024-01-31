using Entities;
using Newtonsoft.Json;

namespace MyData
{
    public static class DataBase
    {
        private static readonly string _membersFilePath = "Members.json";
        public static List<Member> Members { get; set; } = new List<Member>();


        public static List<Member> GetMembers() => Members;


        public static void SaveMembers<T>(List<T> MemberList)
        {
            var jsonFile = JsonConvert.SerializeObject(MemberList);
            File.WriteAllText(_membersFilePath, jsonFile);
        }

        public static List<T> LoadMembers<T>()
        {
            try
            {
                var data = File.ReadAllText(_membersFilePath);
                return JsonConvert.DeserializeObject<List<T>>(data);
            }
            catch (FileNotFoundException)
            {
                File.Create(_membersFilePath).Close();
                File.WriteAllText(_membersFilePath, "[]");
                var data = File.ReadAllText(_membersFilePath);
                return JsonConvert.DeserializeObject<List<T>>(data);
            }
        }
    }
}
