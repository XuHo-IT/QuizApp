﻿using QuizApp_API.Model;

namespace QuizApp_API.Service
{
    public interface IQuizService
    {
        public Task<List<Quiz>> GetQuizzes();
    }
}
