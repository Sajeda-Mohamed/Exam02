using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C___OOP_
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string? header, string? body, double mark, List<Answers> answers, Answers correctAnswer) : base(header, body, mark, answers, correctAnswer)
        { }
        public void DisplayMCQQuestion(string questionBody, double questionMark, int correctAnswer, List<string> answers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Choose One Answer Question\tMark({questionMark}) ");
            Console.WriteLine($"{questionBody}");
            int i = 1;
            SortedList<int,string> Ans = new SortedList<int, string>();
            foreach (string answer in answers)
            {  
                Console.Write($"{i}.{answer}\t");
                Ans.Add(i, answer);
                i++; 
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            bool flagChoice = int.TryParse(Console.ReadLine(), out int choice);
            stopwatch.Stop();
            string body = questionBody;
            //int Choice = choice;
            string result = null;
            foreach (KeyValuePair<int,string> item in Ans)
            {
                if (item.Key == choice)
                    result = item.Value;
            }
            int correct = correctAnswer;
            TimeSpan time = stopwatch.Elapsed;
            MCQQuestion.DisplayAnswers(body, result, choice, correct, time);
        }
        public static void DisplayAnswers (string questionBody, string Choice, int numOfChoice, int corrcetAnswer, TimeSpan time)
        {
            int grade = 0;
            Console.WriteLine("Your Answers");
            Console.WriteLine($"Q1) {questionBody} : {corrcetAnswer}");
            if (numOfChoice == corrcetAnswer)
                grade = 2;
            Console.WriteLine($"{grade} from 2");
            Console.WriteLine($"The Time Elapsed = {time}");
        }
    }
}
