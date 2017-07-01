using System;
using System.ComponentModel.DataAnnotations;

namespace AA.Services
{
    public class Login
    {

        public Login(string userName, string password)
        {
            Valid = false;
            UserName = userName;
            Password = password;

            Validate(UserName, Password);
        }

        private void Validate(string userName, string password)
        {
            if (userName == "test" &&
               password == "test")
            {
                Valid = true;
            }
            else
            {
                throw new ArgumentException("UserName or Password is not valid");
            }
        }

        [Required(ErrorMessage = "UserName is required")]
        internal string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        internal string Password { get; set; }

        private bool Valid { get; set; }
    }
}