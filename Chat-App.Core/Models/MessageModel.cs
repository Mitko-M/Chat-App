using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Core.Models
{
    public class MessageModel
    {
        public string UserId { get; set; }
        public string Text { get; set; }
        public int ChatGroupId { get; set; }
    }
}
