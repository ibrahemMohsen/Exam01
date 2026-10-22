using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01
{
    internal abstract class Exam
    {
        public Exam(int timeOfExam, int numberOfQuestions, Question[]? questions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
            Questions = new Question[numberOfQuestions];
        }
        public Exam(Subject subject, int timeOfExam, int numberOfQuestions)
        {
            Subject = subject;
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[]? Questions { get; set; }
        public Subject? Subject { get; set; }

        public abstract void ShowExam();
        public abstract void CreateExam();

        public int AskQuestion(int number, Question question)
        {
            Console.WriteLine($"Question {number}: {question.Body}");
            Console.WriteLine($"{question.Type} Question: Mark {question.Mark}");
            for (int i = 0; i < question.AnswerList!.Length; i++)
            {
                Console.WriteLine($"{i+1}- {question.AnswerList[i].AnswerText}");
            }
            int answerId = Helpers.ParseInt("Enter your answer ID: ");
            return answerId;
        }

    }
}

