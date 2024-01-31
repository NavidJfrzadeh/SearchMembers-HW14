using Entities;
using Newtonsoft.Json;

namespace MyData;

public static class DataBase
{

    #region Fields
    private static readonly string _membersFilePath = "Members.json";
    public static List<Member> Members { get; set; } = new List<Member>();
    #endregion

    #region Methods
    public static List<Member> GetMembers() => Members;

    public static void SaveMember(Member model)
    {
        model.Id = GenerateMemberId();
        Members.Add(model);
        SaveMembers<Member>(Members);
    }

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
    #endregion

    #region PrivateMethods
    private static int GenerateMemberId()
    {
        var data = File.ReadAllText(_membersFilePath);
        var members = JsonConvert.DeserializeObject<List<Member>>(data);

        if (members != null)
        {
            var lastMemberId = members.Max(x => x.Id) + 1;
            return lastMemberId;
        }
        else
        {
            return 1;
        }
    }
    #endregion
}