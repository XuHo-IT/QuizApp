using Microsoft.EntityFrameworkCore;
using QuizApp_API.Model;

namespace QuizApp_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Quiz> Quizs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quiz>().HasData(
                new Quiz
                {
                    QuizId = 1,
                    Question = "What is the capital of France?",
                    AnswerString = "Paris;London;Berlin;Rome",
                    CorrectAnswerIndex = 0
                },
                new Quiz
                {
                    QuizId = 2,
                    Question = "What is 2 + 2?",
                    AnswerString = "3;4;5;22",
                    CorrectAnswerIndex = 1
                },
                new Quiz
                {
                    QuizId = 3,
                    Question = "Which planet is known as the Red Planet?",
                    AnswerString = "Earth;Mars;Jupiter;Saturn",
                    CorrectAnswerIndex = 1
                },
                new Quiz
                {
                    QuizId = 4,
                    Question = "Who wrote 'Romeo and Juliet'?",
                    AnswerString = "Shakespeare;Dickens;Tolkien;Austen",
                    CorrectAnswerIndex = 0
                },
                new Quiz
                {
                    QuizId = 5,
                    Question = "Which gas do plants absorb from the atmosphere?",
                    AnswerString = "Oxygen;Nitrogen;Carbon Dioxide;Hydrogen",
                    CorrectAnswerIndex = 2
                }
            );
        }
    }
}
