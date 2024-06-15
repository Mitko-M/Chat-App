using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Chat_App.Infrastructure.Common.ValidationConstants;

namespace Chat_App.Infrastructure.Data.Models
{
    public class ChatGroup
    {
        [Key]
        [Comment("Chat group identifier")]
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Comment("Chat group's name")]
        [StringLength(ChatGroupNameMax, MinimumLength = ChatGroupNameMin, ErrorMessage = LengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<ChatGroupUsers> ChatGroupUsers { get; set; } = new List<ChatGroupUsers>();
        public IEnumerable<Message> Messages { get; set; } = new List<Message>();
    }
}
