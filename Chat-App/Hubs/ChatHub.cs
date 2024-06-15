using Chat_App.HubsContracts;
using Microsoft.AspNetCore.SignalR;

namespace Chat_App.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
        }
    }
}
