using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Exam01
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions, Question[]? questions) : base(timeOfExam, numberOfQuestions, questions)
        {
        }
        public FinalExam(Subject subject, int timeOfExam, int numberOfQuestions) : base(subject, timeOfExam, numberOfQuestions)
        {
        }

        public override void CreateExam()
        {
            
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            int grade = 0;
            int[] answerIds = new int[Questions!.Length];
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < Questions!.Length; i++)
            {
                answerIds[i] = AskQuestion(i + 1, Questions[i]);
                if (answerIds[i] == Questions[i].CorrectAnswer!.AnswerId)
                {
                    grade += Questions[i].Mark;
                }
        Console.WriteLine();
    }
    stopwatch.Stop();
    Console.WriteLine("Final Exam Results:");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer => {Questions[i].AnswerList![answerIds[i] - 1].AnswerText}");
                Console.WriteLine($"Correct Answer => {Questions[i].CorrectAnswer!.AnswerText}");
                Console.WriteLine();
                Console.WriteLine($"Grade: {grade}");
                Console.WriteLine($"Time spent: {stopwatch.Elapsed:mm\\:ss}");
                Console.WriteLine("Thank You");
            }
        }
    }
}
