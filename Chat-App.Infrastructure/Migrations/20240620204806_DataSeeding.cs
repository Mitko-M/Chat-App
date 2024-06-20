using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chat_App.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c19b0c6-9d3a-4f2f-a408-674fb35eccc5", 0, "0ff8dfbe-8045-4486-90c4-653146d21cc1", "AppUser", "mitkomitkov@gmail.com", false, "Mitko", "Mitkov", false, null, "MITKOMITKOV@GMAIL.COM", "MITKO123", "AQAAAAIAAYagAAAAEBMM1sziyIokCY0gPA9sKuvkG9p6ZCzPTLDdW3TqCrmq4ups67oRCKRxVjfHzoO3Iw==", null, false, "e7732c5b-6dd5-4067-9b0d-30513ac5ea7f", false, "mitko123" },
                    { "b66261da-d44f-4b92-8ec7-f1dc00c26016", 0, "b3b9007d-5983-4d00-8c71-9b2432d65d92", "AppUser", "ivanmilev@gmail.com", false, "Ivan", "Milev", false, null, "IVANMILEV@GMAIL.COM", "IVAN123", "AQAAAAIAAYagAAAAEMBK51wiZ4o9PzyDVNRdEbDWC0D7uppZXE0nxTMOxeA4BN0baOgZAW6elV40lc+nqg==", null, false, "fe1bfe24-21f2-492a-bfd8-4ea7f7f4b8e5", false, "ivan123" }
                });

            migrationBuilder.InsertData(
                table: "ChatGroups",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "First Chat Room" });

            migrationBuilder.InsertData(
                table: "ChatGroupsUsers",
                columns: new[] { "ChatGroupId", "UserId" },
                values: new object[,]
                {
                    { 1, "0c19b0c6-9d3a-4f2f-a408-674fb35eccc5" },
                    { 1, "b66261da-d44f-4b92-8ec7-f1dc00c26016" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChatGroupsUsers",
                keyColumns: new[] { "ChatGroupId", "UserId" },
                keyValues: new object[] { 1, "0c19b0c6-9d3a-4f2f-a408-674fb35eccc5" });

            migrationBuilder.DeleteData(
                table: "ChatGroupsUsers",
                keyColumns: new[] { "ChatGroupId", "UserId" },
                keyValues: new object[] { 1, "b66261da-d44f-4b92-8ec7-f1dc00c26016" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c19b0c6-9d3a-4f2f-a408-674fb35eccc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b66261da-d44f-4b92-8ec7-f1dc00c26016");

            migrationBuilder.DeleteData(
                table: "ChatGroups",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
