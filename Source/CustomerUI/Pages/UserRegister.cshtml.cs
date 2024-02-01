
using MyData;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyData;

namespace CustomerUI.Pages
{
    public class UserRegisterModel : PageModel
    {
        [BindProperty]
        public Member NewMember { get; set; } = new Member();

        public void OnGet()
        {

        }


        [HttpPost]
        public void OnPost()
        {
            DataBase.Members = DataBase.LoadMembers<Member>();

            if (ModelState.IsValid)
            {
                if (NewMember != null)
                {
                    if (!DataBase.SaveMember(NewMember))
                    {
                        ModelState.AddModelError("NationalCode", "کد ملی تکراری است");
                    }
                }
            }


        }
    }
}
