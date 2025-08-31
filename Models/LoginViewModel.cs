using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username cannot be left blank")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password cannot be left blank")]
        public string Password { get; set; }
    }
}
