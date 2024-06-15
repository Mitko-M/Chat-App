using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Chat_App.Infrastructure.Common.ValidationConstants;

namespace Chat_App.Infrastructure.Data.Models
{
    public class AppUser : IdentityUser
    {
        [Comment("An application user's first name")]
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(FirstNameMax, MinimumLength = FirstNameMin, ErrorMessage = LengthErrorMessage)]
        public string FirstName { get; set; } = string.Empty;

        [Comment("An application user's last name")]
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(LastNameMax, MinimumLength = LastNameMin, ErrorMessage = LengthErrorMessage)]
        public string LastName { get; set; } = string.Empty;

        public IEnumerable<ChatGroupUsers> ChatGroupUsers { get; set; } = new List<ChatGroupUsers>();
        public IEnumerable<Message> Messages { get; set; } = new List<Message>();
    }
}
