using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sommerhus.Model;
using Sommerhus.Repository07;
using System.ComponentModel.DataAnnotations;

namespace SommerhusHjemmeside.Pages.UserSite
{
    public class CreateModel : PageModel
    {

        private IUserRepostiroy _repo;

        // dependency injection
        public CreateModel(IUserRepostiroy userrepo)
        {
            _repo = userrepo;
        }

        // Properties til de nye brugere



        [BindProperty]
        [Required(ErrorMessage = "Der skal være et navn")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Der skal være mindst to tegn i et navn")]
        public string NewUserFirstName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "SORRY SIR! THE PHONENUMBER IS EITHER TOO SHORT OR TOO LONG!")]
        public string NewUserLastName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "hellooooooooooo sir! this team doesnt exist")]
        public string NewUserPhone { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Most be higher than 0")]
        public string NewUserEmail { get; set; }

        [BindProperty]
        public string NewUserPassword { get; set; }

        [BindProperty]
        public string NewUserStreetName { get; set; }

        [BindProperty]
        public string NewUserHouseNumber { get; set; }

        [BindProperty]
        public string NewUserFloor { get; set; }

        [BindProperty]
        public int NewUserPostalCode { get; set; }

        [BindProperty]
        public bool NewUserIsAdmin { get; set; }
        [BindProperty]
        public bool NewUserIsLandLord { get; set; }

        public string ErrorMessage { get; private set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            ErrorMessage = "fEJL 404 KUNNE IKKE OPRETTE EN USER";
            if (!ModelState.IsValid)
            {
                return Page();
            }
            User newuser = new User(NewUserFirstName, NewUserLastName, NewUserPhone, NewUserEmail, NewUserPassword, NewUserStreetName, NewUserHouseNumber, NewUserFloor, NewUserPostalCode, NewUserIsLandLord, NewUserIsAdmin);

            try
            {
                _repo.Add(newuser);
                TempData["SuccessMessage"] = $"User {newuser} added successfully";

            }
            catch (ArgumentException ex)
            {
                ErrorMessage = ex.Message;
                return Page();
            }

            return RedirectToPage("LogIn");

        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("LogIn");
        }

    }
}
