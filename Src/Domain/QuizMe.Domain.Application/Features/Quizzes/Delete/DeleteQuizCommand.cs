﻿namespace QuizMe.Domain.Application.Features.Quizzes.Delete
{
    public class DeleteQuizCommand:IRequest<ValidatedResult<bool>>
    {
        public string Id { get; set; }
    }
}
