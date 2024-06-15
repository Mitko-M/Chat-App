using Chat_App.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chat_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<AppUser> ApplicationUsers { get; set; }
        public DbSet<ChatGroup> ChatGroups { get; set; }
        public DbSet<ChatGroupUsers> ChatGroupsUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChatGroupUsers>(cgu => cgu.HasKey(e => new
            {
                e.ChatGroupId,
                e.UserId
            }));

            builder.Entity<ChatGroupUsers>()
                .HasOne(u => u.User)
                .WithMany(cg => cg.ChatGroupUsers)
                .HasForeignKey(u => u.UserId);

            builder.Entity<ChatGroupUsers>()
                .HasOne(cg => cg.ChatGroup)
                .WithMany(cg => cg.ChatGroupUsers)
                .HasForeignKey(cg => cg.ChatGroupId);

            base.OnModelCreating(builder);
        }
    }
}
