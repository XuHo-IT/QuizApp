

using QuizApp_UI.Models;

namespace QuizApp_UI.Service
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }

        Task<T> SendAsync<T>(APIRequest apIRequest);
    }
}
