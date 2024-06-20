using Chat_App.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Chat_App.Infrastructure.Data.Configuration.ConfigurationHelper;

namespace Chat_App.Infrastructure.Data.Configuration
{
    public class ChatGroupUsersConfiguration : IEntityTypeConfiguration<ChatGroupUsers>
    {
        public void Configure(EntityTypeBuilder<ChatGroupUsers> builder)
        {
            builder.HasData(
            [
                new ChatGroupUsers()
                {
                    UserId = Users[0].Id,
                    ChatGroupId = 1
                },
                new ChatGroupUsers() 
                {
                    UserId = Users[1].Id,
                    ChatGroupId = 1
                }
            ]);
        }
    }
}
