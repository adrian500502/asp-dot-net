using System.ComponentModel.DataAnnotations;

namespace AspNetAB.ViewModels
{
    public class Login
    {
        [Required, DataType(DataType.EmailAddress), StringLength(50, MinimumLength = 5, ErrorMessage = "Email length too short!")]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), StringLength(50, MinimumLength = 5, ErrorMessage = "Password length too short!")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
