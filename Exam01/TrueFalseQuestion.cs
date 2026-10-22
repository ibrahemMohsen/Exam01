using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string? header, string? body, int mark, Answer[]? answerList, Answer? correctAnswer) : base(header, body, mark, answerList, correctAnswer)
        {
        }
        public TrueFalseQuestion(string body, int mark, Answer rightAnswer)
        : this("", body, mark, CreateAnswers(), rightAnswer)
        {
        }
        private static Answer[] CreateAnswers() => new[]
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        };
    }
}