using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01
{
    internal class Question
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer[]? AnswerList { get; set; }
        public Answer? CorrectAnswer { get; set; }
        public string? Type { get; set; }
        public Question(string? header, string? body, int mark, Answer[]? answerList, Answer? correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            CorrectAnswer = correctAnswer;
        }
    }
}
