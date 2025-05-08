using QuizApp;
using QuizApp_UI.Models;

namespace QuizApp_UI.Service
{
    public class QuizService : BaseService, IQuizService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string quizUrl;

        public QuizService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            quizUrl = configuration.GetValue<string>("Url:QuizAPI");
        }

        public Task<T> GetAllQuizzes<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = SD.ApiType.GET,
                Url = quizUrl + "/all-questions",
            });
        }
    }
}
