using Chat_App.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Chat_App.Infrastructure.Data.Configuration
{
    public static class ConfigurationHelper
    {
        private static PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();

        public static AppUser[] Users = GetUsers();

        private static AppUser[] GetUsers()
        {
            AppUser user1 = new AppUser()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Mitko",
                LastName = "Mitkov",
                UserName = "mitko123",
                NormalizedUserName = "MITKO123",
                Email = "mitkomitkov@gmail.com",
                NormalizedEmail = "MITKOMITKOV@GMAIL.COM",
            };

            AppUser user2 = new AppUser()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Ivan",
                LastName = "Milev",
                UserName = "ivan123",
                NormalizedUserName = "IVAN123",
                Email = "ivanmilev@gmail.com",
                NormalizedEmail = "IVANMILEV@GMAIL.COM",
            };

            user1.PasswordHash = hasher.HashPassword(user1, "mitko");
            user2.PasswordHash = hasher.HashPassword(user2, "ivan");

            var result = new AppUser[] { user1, user2 };

            return result;
        }
    }
}
