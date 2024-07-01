using Chat_App.Hubs;
using Chat_App.HubsContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Chat_App.Controllers
{
    public class ChatController : BaseController
    {
        private IHubContext<ChatHub, IChatClient> chatHubContext;
        public ChatController(
            IHubContext<ChatHub, IChatClient> _chatHubContext)
        {
            chatHubContext = _chatHubContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveMessage()
        {
            throw new NotImplementedException();
        }
    }
}
