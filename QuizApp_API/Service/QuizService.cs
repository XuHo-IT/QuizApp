using Microsoft.EntityFrameworkCore;
using QuizApp_API.Data;
using QuizApp_API.Model;

namespace QuizApp_API.Service
{
    public class QuizService : IQuizService
    {
        private readonly ApplicationDbContext _context;

        public QuizService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Quiz>> GetQuizzes()
        {
            return await _context.Quizs.ToListAsync();

        }
    }

}
