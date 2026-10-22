using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;

        }
        public void CreateExam()
        {
            int type = Helpers.ParseInt("Enter the type of exam (1 for Practical, 2 for Final):", 1, 2);
            int time = Helpers.ParseInt("Please enter the time for the exam (30 to 180 minutes):", 30, 180);
            int count = Helpers.ParseInt("Please enter the number of questions:", 1);

            bool isFinal = type == 2;
            Exam = isFinal
                ? new FinalExam(this, time, count)
                : new PracticalExam(this, time, count);
            //Console.Clear();
            for(int i = 0; i < count; i++)
            {
                int questionType = 1;
                if (isFinal)
                {
                    Console.WriteLine($"Enter Details For question {i+1}:");
                    questionType = Helpers.ParseInt("Choose Question Type: 1 for MCQ, 2 for True/False", 1, 2);
                    //Console.Clear();
                }
                Exam.Questions[i] = questionType == 1 ? ReadMcq() : ReadTrueFalse();
            }
        }
        private static MCQQuestion ReadMcq()
        {
            Console.WriteLine("Please enter the question body:");
            string body = Console.ReadLine()!;
            int mark = Helpers.ParseInt("Please enter the question mark:", 1);

            Console.WriteLine("Choices of Question:");
            Answer[] choices = new Answer[4];
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"Please enter choice number {i + 1}:");
                string text = Console.ReadLine()!;
                choices[i] = new Answer(i + 1, text);
            }

            int right = Helpers.ParseInt("Please enter the ID of the correct answer (1 to 4):", 1, 4);
            Answer rightAnswer = new Answer(right, choices[right - 1].AnswerText);
            return new MCQQuestion("", body, mark, choices, rightAnswer);
        }

        private static TrueFalseQuestion ReadTrueFalse()
        {
            Console.WriteLine($"Please enter the question body:");
            string body = Console.ReadLine()!;
            int mark = Helpers.ParseInt("Please enter the question mark:", 1);
            int right = Helpers.ParseInt("Please enter the ID of the correct answer (1 for True, 2 for False):", 1, 2);
            Answer rightAnswer = new Answer(right, right == 1 ? "true": "false");
            return new TrueFalseQuestion(body, mark, rightAnswer);
        }
    }
}
