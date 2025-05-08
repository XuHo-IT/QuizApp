using static QuizApp.SD;

namespace QuizApp_UI.Models
{
    public class APIRequest
    {
        public ApiType APIType { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
