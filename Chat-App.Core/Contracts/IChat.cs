using Chat_App.Core.Models;

namespace Chat_App.Core.Contracts
{
    public interface IChat
    {
        Task SaveChatMessage(MessageModel message);
        Task<IEnumerable<MessageModel>> LoadChatMessages(int chatGroupId);
    }
}
