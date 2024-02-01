using AdminUI.Repository;
using MyData;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminUI.Pages
{
    public class UpdateModel : PageModel
    {
        CRUDaction crudAction = new CRUDaction();

        [BindProperty]
        public Member MemberForUpdate { get; set; }



        [HttpGet]
        public IActionResult OnGet(int id)
        {
            MemberForUpdate = crudAction.GetUserById(id);

            if (MemberForUpdate == null)
                return NotFound();

            return Page();
        }



        [HttpPost]
        public IActionResult OnPost()
        {
            var targetMember = crudAction.GetUserById(MemberForUpdate.Id);
            if (targetMember == null) return NotFound();

            crudAction.UpdateUser(MemberForUpdate);

            return RedirectToPage("SearchMember");
        }
    }
}
