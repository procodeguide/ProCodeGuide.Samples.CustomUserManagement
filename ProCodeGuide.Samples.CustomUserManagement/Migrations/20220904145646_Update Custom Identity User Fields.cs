using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProCodeGuide.Samples.CustomUserManagement.Migrations
{
    public partial class UpdateCustomIdentityUserFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "CstUserMngt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                schema: "CstUserMngt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "CstUserMngt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Picture",
                schema: "CstUserMngt",
                table: "Users");
        }
    }
}
