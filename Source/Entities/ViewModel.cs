using System.ComponentModel;


namespace Entities
{
    //public record ViewModel(string Name, string LastName);

    public class MemberModel
    {
        [DisplayName("نام")]
        public string? Name { get; set; }
        [DisplayName("نام خانوادگی")]
        public string? LastName { get; set; }
    }
}
