namespace Exam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add Question MCQ (MCQ Question)
            // Add Question TF (TF Question)
            // Show Correct Answers and grade (both practical and final exams) (practicalExam and final exam)
            // create exam (Subject)
            // helpers: loop for correct int parsing, correct string parsing ()
            // Main method
            Subject subject = new Subject(1, "OOP");
            subject.CreateExam();
            subject.Exam.ShowExam();


        }
    }
}
