using AdminUI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminUI.Pages
{
    public class DeleteMemberModel : PageModel
    {
        CRUDaction crudAction = new CRUDaction();

        [HttpPost]
        public IActionResult OnPost(int id)
        {
            crudAction.DeleteUser(id);
            return RedirectToPage("SearchMember");
        }
    }
}