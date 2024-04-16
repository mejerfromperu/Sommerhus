using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using Sommerhus.Model;
using Sommerhus.Repository07;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SommerhusHjemmeside.Pages.UserSite
{
    public class LogInModel : PageModel
    {
        private IUserRepostiroy _repo;

        public LogInModel(IUserRepostiroy userRepo)
        {
            _repo = userRepo;
        }

        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Fetch user by email and password
            var user = _repo.GetByEmailAndPassword(Email, Password);

            if (user != null)
            {
                // Authentication successful
                // You can set session variables or identity claims here

                // Store a success message in TempData
                TempData["Message"] = "Login successful!";

                return RedirectToPage("Index");
            }

            // Authentication failed
            ModelState.AddModelError(string.Empty, "Invalid email or password");
            return Page();
        }

    }


}





