using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizApp_API.Migrations
{
    /// <inheritdoc />
    public partial class Quiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizs",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswerIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizs", x => x.QuizId);
                });

            migrationBuilder.InsertData(
                table: "Quizs",
                columns: new[] { "QuizId", "AnswerString", "CorrectAnswerIndex", "Question" },
                values: new object[,]
                {
                    { 1, "Paris;London;Berlin;Rome", 0, "What is the capital of France?" },
                    { 2, "3;4;5;22", 1, "What is 2 + 2?" },
                    { 3, "Earth;Mars;Jupiter;Saturn", 1, "Which planet is known as the Red Planet?" },
                    { 4, "Shakespeare;Dickens;Tolkien;Austen", 0, "Who wrote 'Romeo and Juliet'?" },
                    { 5, "Oxygen;Nitrogen;Carbon Dioxide;Hydrogen", 2, "Which gas do plants absorb from the atmosphere?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quizs");
        }
    }
}
