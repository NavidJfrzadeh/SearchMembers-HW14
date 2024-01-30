using AdminUI.Repository;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminUI.Pages
{
    public class DetailsModel : PageModel
    {
        CRUDaction crudAction = new CRUDaction();


        [BindProperty]
        public Member CurrentMember { get; set; }



        public IActionResult OnGet(int id)
        {
            var targetMember = crudAction.GetUserById(id);
            CurrentMember = targetMember;

            if (CurrentMember == null)
                return NotFound();

            return Page();
        }

    }
}
