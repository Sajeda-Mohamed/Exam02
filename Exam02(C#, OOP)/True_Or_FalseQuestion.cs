using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C___OOP_
{
    internal class True_Or_FalseQuestion : Question
    {
        public True_Or_FalseQuestion(string? header, string? body, double mark, Answers correctAnswer)
            : base(header, body, mark, new List<Answers> { new Answers(1, "True"), new Answers(2, "False") }, correctAnswer)
        { }
        public void DisplayTorFQuestions(string questionBody, double questionMark, int correctAnswer)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"True | False Question\tMark({questionMark})");
            Console.WriteLine($"{questionBody}");
            Console.WriteLine("1. True\t  2. False");
            Console.WriteLine("--------------------------");
            bool flagChoice = int.TryParse(Console.ReadLine(), out int choice);
            stopwatch.Stop();
            Console.WriteLine("====================================");
            string body = questionBody;
            int Choice = choice;
            int correct = correctAnswer;
            TimeSpan time = stopwatch.Elapsed;
            True_Or_FalseQuestion.DisplayAnswers(body, Choice, correct, time);
        }
        public static void DisplayAnswers(string body, int choice, int correct, TimeSpan time)
        {
            int grade = 0;
            string Choice;
            if (choice == 1)
                Choice = "True";
            else
                Choice = "False";

            Console.WriteLine($"Q1) {body} : {correct}");
            if (choice == correct)
                grade = 2;
            Console.WriteLine($"{grade} from 2");
            Console.WriteLine($"The Time Elapsed = {time}");
        }

    }
}
