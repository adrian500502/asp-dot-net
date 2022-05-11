using System.ComponentModel.DataAnnotations;

namespace AspNetAB.ViewModels
{
    public class Register
    {
        [Required, DataType(DataType.EmailAddress), StringLength(50, MinimumLength = 5, ErrorMessage = "Email has to contain at least 5 characters!")]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), StringLength(50, MinimumLength = 5, ErrorMessage = "Password has to contain at least 5 characters!")]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), StringLength(50, MinimumLength = 5, ErrorMessage = "Password has to contain at least 5 characters!"),
            Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
