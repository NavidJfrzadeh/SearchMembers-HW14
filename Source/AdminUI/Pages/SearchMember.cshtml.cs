using AdminUI.Repository;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyData;
using System.Text.Json;

namespace AdminUI.Pages
{
    public class SearchMemberModel : PageModel
    {
        CRUDaction actions = new CRUDaction();
        Search Search = new Search();
        public List<Member> Members { get; set; }

        [BindProperty]
        public MemberModel MemberModel { get; set; }

        public SearchMemberModel()
        {
            DataBase.Members = DataBase.LoadMembers<Member>();
        }


        [HttpGet]
        public void OnGet(List<Member> members)
        {
            //Members = DataBase.GetMembers();
        }

        [HttpGet]
        public IActionResult OnGetDelete(int id)
        {
            if (actions.DeleteUser(id))
                return RedirectToPage("SearchMember");

            return NotFound();
        }


        [HttpPost]
        public IActionResult OnPost()
        {
            var members = Search.GetMembers(MemberModel);
            TempData["members"] = JsonSerializer.Serialize(members);
            return RedirectToPage("ShowMembers");
            //return RedirectToAction("OnGet", members);
            //return Page();
        }
    }
}
