using System.ComponentModel.DataAnnotations;
using static Chat_App.Infrastructure.Common.ValidationConstants;

namespace Chat_App.Core.Models.Identity
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "First Name")]
        [StringLength(FirstNameMax, MinimumLength = FirstNameMin, ErrorMessage = LengthErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Last Name")]
        [StringLength(LastNameMax, MinimumLength = LastNameMin, ErrorMessage = LengthErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(UserNameMax, MinimumLength = UserNameMin, ErrorMessage = LengthErrorMessage)]
        [Display(Name = "Username")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        [StringLength(EmailMax, MinimumLength = EmailMin, ErrorMessage = LengthErrorMessage)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(PassMax, MinimumLength = PassMin)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
