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


        public LogInModel(IUserRepostiroy userrepo)
        {
            _repo = userrepo;
        }


        [BindProperty]
        [Required(ErrorMessage = "Most be higher than 0")]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public User GetByEmailAndPassword(string email, string password)

        {

            SqlConnection connection = new SqlConnection(Secret.GetConnectionString);

            {

                connection.Open();



                string selectSql = "SELECT * FROM [User] WHERE Email = @Email AND Password = @Password";



                using (SqlCommand cmd = new SqlCommand(selectSql, connection))

                {

                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.Parameters.AddWithValue("@Password", password);



                    using (SqlDataReader reader = cmd.ExecuteReader())

                    {

                        if (reader.Read())

                        {

                            return new User

                            {

                                Id = reader.GetInt32(reader.GetOrdinal("Id")),

                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),

                                LastName = reader.GetString(reader.GetOrdinal("LastName")),

                                Phone = reader.GetString(reader.GetOrdinal("Phone")),

                                Email = reader.GetString(reader.GetOrdinal("Email")),

                                Password = reader.GetString(reader.GetOrdinal("Password")),

                                StreetName = reader.GetString(reader.GetOrdinal("StreetName")),

                                HouseNumber = reader.GetString(reader.GetOrdinal("HouseNumber")),

                                Floor = reader.GetString(reader.GetOrdinal("Floor")),

                                City = reader.GetString(reader.GetOrdinal("City")),

                                PostalCode = reader.GetInt32(reader.GetOrdinal("PostalCode")),

                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin")),

                                IsLandlord = reader.GetBoolean(reader.GetOrdinal("IsLandlord"))

                            };


                        }

                    }
                     
                    if(email == Email &&  password == Password)
                    {
                        IsEmailConfirmed = true;
                    }
                    

                    return null;

                }

            }

        }

        public void OnGet()
        {

        }


        public IActionResult OnPost()
        {

            GetByEmailAndPassword(Email, Password);

            return RedirectToPage("Index");


            
        }



    }

} 

 

 
   
