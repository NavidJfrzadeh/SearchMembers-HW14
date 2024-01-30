using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyData;

namespace AdminUI.Pages
{
    public class SearchMemberModel : PageModel
    {
        public List<Member> Members { get; set; }

        [BindProperty]
        public MemberModel MemberModel { get; set; }



        public void OnGet()
        {
            Members = DataBase.GetMembers();
        }


        [HttpPost]
        public void OnPost()
        {

        }
    }
}
