using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace AdminUI.Pages
{
    public class ShowMembersModel : PageModel
    {
        [BindProperty]
        public List<Member> MemList { get; set; }
        public void OnGet()
        {
            var data = TempData["Members"] as string;
            MemList = JsonSerializer.Deserialize<List<Member>>(data);
        }

        public void OnPost()
        {

        }
    }
}
