using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sommerhus.Repository07;

namespace SommerhusHjemmeside.Pages.UserSite
{
    public class CreateModel : PageModel
    {

        private IUserRepostiroy _repo;


        public void OnGet()
        {
        }
    }
}
