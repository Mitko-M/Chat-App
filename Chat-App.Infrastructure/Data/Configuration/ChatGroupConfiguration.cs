using Chat_App.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chat_App.Infrastructure.Data.Configuration
{
    public class ChatGroupConfiguration : IEntityTypeConfiguration<ChatGroup>
    {
        public void Configure(EntityTypeBuilder<ChatGroup> builder)
        {
            builder.HasData(new ChatGroup()
            {
                Id = 1,
                Name = "First Chat Room"
            });
        }
    }
}
