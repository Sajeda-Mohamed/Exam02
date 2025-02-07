using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C___OOP_
{
    internal class Question
    {
        public string? Header { get; set; } 
        public string? Body { get; set; }
        public double Mark { get; set; }
        public Answers CorrectAnswer { get; set; }
        public List<Answers> Answerss { get; set; }

        public Question() { }
        public Question(string? header, string? body, double mark, List<Answers> answers, Answers correcetAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answerss = answers;
            CorrectAnswer = correcetAnswer;
        }
        public void ChooseQuestions(int numOfQuestions)
        {
            for (int i = 1; i <= numOfQuestions; i++)
            {
                Console.Write($"Please Choose The Type Of Question Number({i}) " +
                    $"(1 for True or False || 2 for MCQ) : ");
                bool TorFOrMCQ = int.TryParse(Console.ReadLine(), out int choiceOfQuestion);
                Console.Clear();
                if (choiceOfQuestion == 1)
                {
                    Question question = new Question();
                    question.ReceiveTorFQuestion(numOfQuestions);
                }
                if (choiceOfQuestion == 2)
                {
                    Question question = new Question();
                    question.ReceiveMCQQuestions(numOfQuestions);               
                }
            }
        }
        public void ReceiveTorFQuestion(int n)
        {
            Console.WriteLine("True | False Question");
            Console.WriteLine("Please Enter The Body Of Question:");
            string? questionBody = Console.ReadLine() ?? " Empty";
            Console.Write("Please Enter The Mark Of Question : ");
            bool flagMark = double.TryParse(Console.ReadLine(), out double questionMark);
            Console.Write("PLease Enter The Right Answer of Question (1 for True & 2 for False) : ");
            bool flagAnswer = int.TryParse(Console.ReadLine(), out int correctAnswer);
            Console.Clear();
            Question question = new Question();
            True_Or_FalseQuestion true_Or_FalseQuestion = new True_Or_FalseQuestion(Header, Body, Mark, CorrectAnswer);
            Console.Write("Do you want to start The Exam (y | n)");
            string? choice = Console.ReadLine() ?? " Empty";
            if (choice == "y")
            {
                true_Or_FalseQuestion.DisplayTorFQuestions(questionBody, questionMark, correctAnswer);
            }
        }
        public void ReceiveMCQQuestions(int n)
        {
            Console.WriteLine("Choose One Answer Question");
            Console.WriteLine("Please Enter The Body Of Question:");
            string? questionBody = Console.ReadLine() ?? " Empty";
            Console.Write("Please Enter The Mark Of Question : ");
            bool flagMark = double.TryParse(Console.ReadLine(), out double mark);
            Console.WriteLine("The Choices of Question");
            List<string> Answers = new List<string>();
            for (int i = 1; i < 4; i++)
            {
                Console.Write($"Please Enter The Choice Number({i}) : ");
                string? choice = Console.ReadLine()?? " Empty";
                Answers.Add(choice);
            }
            Console.Write("Please Specify The Number of Correct Choice of question : ");
            bool corrrectChoice = int.TryParse(Console.ReadLine(), out int correctChoice);
            Console.Clear();
            Question question = new Question();
            //question.ChooseQuestions(n);
            MCQQuestion mCQQuestion = new MCQQuestion(Header, Body, Mark, Answerss, CorrectAnswer);
            Console.Write("Do you want to start The Exam (y | n) :  ");
            string? choice1 = Console.ReadLine() ?? " Empty";
            if (choice1 == "y")
            {
                mCQQuestion.DisplayMCQQuestion(questionBody, mark, correctChoice, Answers);
            }
        }
    }
}
