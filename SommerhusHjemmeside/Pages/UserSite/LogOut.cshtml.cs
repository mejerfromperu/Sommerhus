using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sommerhus.Model;
using SommerhusHjemmeside.Services;

namespace SommerhusHjemmeside.Pages.UserSite
{
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {
            SessionHelper.Clear<User>(HttpContext);

            return RedirectToPage("/Index");
        }
    }
}
