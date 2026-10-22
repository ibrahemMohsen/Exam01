using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string? header, string? body, int mark, Answer[]? answerList, Answer? correctAnswer) : base(header, body, mark, answerList, correctAnswer)
        {
        }
    }
}
