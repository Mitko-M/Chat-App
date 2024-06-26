using Chat_App.HubsContracts;
using Microsoft.AspNetCore.SignalR;

namespace Chat_App.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}
