using Chat_App.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Chat_App.Infrastructure.Data.Configuration.ConfigurationHelper;

namespace Chat_App.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(Users);
        }
    }
}
