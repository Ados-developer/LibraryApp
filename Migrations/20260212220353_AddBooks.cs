using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    IsBorrowed = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "IsBorrowed", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "G.R.R. Martin", false, "A Game of Thrones (A Song of Ice and Fire #1)", null },
                    { 2, "G.R.R. Martin", false, "A Clash of Kings (A Song of Ice and Fire #2)", null },
                    { 3, "G.R.R. Martin", false, "A Storm of Swords (A Song of Ice and Fire #3)", null },
                    { 4, "G.R.R. Martin", false, "A Feast for Crows (A Song of Ice and Fire #4)", null },
                    { 5, "G.R.R. Martin", false, "A Dance with Dragons (A Song of Ice and Fire #5)", null },
                    { 6, "G.R.R. Martin", false, "The Winds of Winter (A Song of Ice and Fire #6)", null },
                    { 7, "G.R.R. Martin", false, "A Dream of Spring (A Song of Ice and Fire #7)", null },
                    { 8, "J.K. Rowling", false, "Harry Potter and the Philosopher's Stone", null },
                    { 9, "J.K. Rowling", false, "Harry Potter and the Chamber of Secrets", null },
                    { 10, "J.K. Rowling", false, "Harry Potter and the Prisoner of Azkaban", null },
                    { 11, "J.K. Rowling", false, "Harry Potter and the Goblet of Fire", null },
                    { 12, "J.K. Rowling", false, "Harry Potter and the Order of the Phoenix", null },
                    { 13, "J.K. Rowling", false, "Harry Potter and the Half-Blood Prince", null },
                    { 14, "J.K. Rowling", false, "Harry Potter and the Deathly Hallows", null },
                    { 15, "J.R.R. Tolkien", false, "The Hobbit", null },
                    { 16, "J.R.R. Tolkien", false, "The Fellowship of the Ring (The Lord of the Rings #1)", null },
                    { 17, "J.R.R. Tolkien", false, "The Two Towers (The Lord of the Rings #2)", null },
                    { 18, "J.R.R. Tolkien", false, "The Return of the King (The Lord of the Rings #3)", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
