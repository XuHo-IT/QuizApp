namespace QuizApp_UI.Service
{
    public interface IQuizService
    {
        Task<T> GetAllQuizzes<T>();
    }
}
