using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Infrastructure.Data.Models
{
    public class Message
    {
        [Key]
        [Comment("A chat message's identifier")]
        public int Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public int ChatGroupId { get; set; }
        [ForeignKey(nameof(ChatGroupId))]
        public ChatGroup ChatGroup { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
    }
}
