using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrej", "Štrba", "wcIksDzZvHtqhtd/XazkAZF2bEhc1V3EjK+ayHMzXW8=", "Admin", "Admin" },
                    { 2, new DateTime(1985, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Kováćová", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "User", "User1" },
                    { 3, new DateTime(1994, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", "Novák", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "User", "User2" },
                    { 4, new DateTime(1979, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucia", "Horvátová", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "User", "User3" },
                    { 5, new DateTime(2002, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", "Šimek", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "User", "User4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
