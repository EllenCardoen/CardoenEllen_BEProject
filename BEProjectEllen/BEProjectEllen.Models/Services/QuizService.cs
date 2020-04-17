using BEProjectEllen.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepo _quizRepo;
        private readonly IChoiceRepo _choiceRepo;

        public QuizService(IQuizRepo quizRepo, IChoiceRepo choiceRepo)
        {
            _quizRepo = quizRepo;
            _choiceRepo = choiceRepo;
        }


        public async Task<UserQuiz> SaveUserQuiz(List<int> choices, int id, string userId)
        {
            var userChoices = new List<UserChoice>();

            foreach (var choice in choices)
            {
                userChoices.Add(new UserChoice() { ChoiceId = choice });
            }

            var correctChoicesFromQuiz = await _choiceRepo.GetCorrectChoiceByQuiz(id) as List<Choice>;

            var correctChoices = correctChoicesFromQuiz.Where(c => choices.Any(ch => ch == c.Id));
            var totalScore = correctChoices.Sum(c => c.Question.ScoreValue);

            // Add new UserQuiz
            var userQuiz = new UserQuiz()
            {
                QuizId = id,
                UserId = userId,
                UserChoices = userChoices,
                Timestamp = DateTime.Now,
                EndScore = totalScore
            };

            //  savechanges
            _quizRepo.AddUserQuiz(userQuiz);
            await _quizRepo.SaveAsync();
            return userQuiz;
        }
    }
}
