using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Infrastructure.Data.Models
{
    public class ChatGroupUsers
    {
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }

        public int ChatGroupId { get; set; }
        [ForeignKey(nameof(ChatGroupId))]
        public ChatGroup ChatGroup { get; set; }
    }
}
