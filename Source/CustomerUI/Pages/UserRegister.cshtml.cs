
using MyData;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyData;
using System.Security.Cryptography.X509Certificates;

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
            if (NewMember != null)
            {
                DataBase.SaveMember(NewMember); 
            }


            var myList = DataBase.GetMembers();

            if (!ModelState.IsValid)
                Page();

          //  DataBase.Members.Add(NewMember);
        }
    }
}
