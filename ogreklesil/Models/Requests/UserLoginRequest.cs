using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using ogr.Data.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using NuGet.Protocol.Plugins;

namespace ogreklesil.Models.Requests
{
    public class UserLoginRequest
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=ogrweb;Integrated Security=True");
       


   

public bool AuthenticateUser(string Username, string Password)
    {
        string connectionstring = "Data source=.;Initial catalog=ogrweb;Integrated security=True";
        string connectionString = "Data Source=.;Initial Catalog=ogrweb;Integrated Security=True";
        string query = "SELECT COUNT(*) FROM giris WHERE [Kullanıcı Adı] = @Username AND [Şifre] = @Password;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            connection.Open();
            int result = (int)command.ExecuteScalar();
            connection.Close();
                if (Username == "admin" && Password == "Password")
                {
                    return View ("/Home/Index");
                }
                return result == 1;
        }
    }

        private bool View(string v)
        {
            throw new NotImplementedException();
        }
    }


        //public class LoginModel : PageModel
        //{
        //    [BindProperty]
        //    public string Username { get; set; } 


        //    [BindProperty]
        //    public string Password { get; set; }

        //    public IActionResult OnPost()
        //    {
        //        if (Username == "admin" && Password == "password")
        //        {
        //            return RedirectToPage("/Home/Index");
        //        }

        //        return Page();
        //    }
        //}
    }
