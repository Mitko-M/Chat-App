namespace Chat_App.HubsContracts
{
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
