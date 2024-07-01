using Chat_App.Core.Contracts;
using Chat_App.Core.Models;
using Chat_App.Data;
using Chat_App.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Chat_App.Core.Services
{
    public class ChatService : IChat
    {
        private readonly ChatAppDbContext context;

        public ChatService(ChatAppDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<MessageModel>> LoadChatMessages(int chatGroupId)
        {
            return await context.Messages
                .Where(m => m.ChatGroupId == chatGroupId)
                .Select(m => new MessageModel()
                {
                    Text = m.Text,
                    ChatGroupId = m.ChatGroupId,
                    UserId = m.UserId
                })
                .ToListAsync();
        }

        public async Task SaveChatMessage(MessageModel message)
        {
            var newMessage = new Message()
            {
                ChatGroupId = message.ChatGroupId,
                UserId = message.UserId,
                Text = message.Text
            };

            await context.Messages.AddAsync(newMessage);

            int save = await context.SaveChangesAsync();

            if (save == 0)
            {
                throw new DbUpdateException("New message couldn't be saved in the database");
            }
        }
    }
}
