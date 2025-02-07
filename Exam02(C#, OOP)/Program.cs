namespace Exam02_C___OOP_
{
    internal class Program
    {
        public static void CheckExamIfPracticalOrFinal()
        {
            Console.Write("Please Enter The Kind Of Exam You want to Create (1 for Practical and 2 for Final) : ");
            bool flagP_Or_F = int.TryParse(Console.ReadLine(), out int choice);
            if (flagP_Or_F && (choice == 2 || choice == 1))
            {
                Console.Write("Enter The Time Of Exam in Minutes : ");
                bool flagM_in_E = DateTime.TryParse(Console.ReadLine(), out DateTime time);
                Console.Write("PLease Enter Number of Question You Wanted To Create : ");
                bool flagN_Of_Q = int.TryParse(Console.ReadLine(), out int numOfQuestions);
                if(choice == 2)
                {
                    FinalExam final = new FinalExam(time, numOfQuestions);
                    final.ReceiveExam();
                }
                else
                {
                    PracticalExam practical = new PracticalExam(time, numOfQuestions);
                    practical.ReceiveExam();
                }
            }
        }
        static void Main(string[] args)
        {
            CheckExamIfPracticalOrFinal();
            //Console.WriteLine();
            //Console.Write("Do you want to start The Exam (y | n)");
            //string? choice = Console.ReadLine() ?? " Empty";
            //if (choice == "y")
            //{
            //    PracticalExam practical = new PracticalExam();
            //    practical.ShowExam();
            //    FinalExam final = new FinalExam();
            //    final.ShowExam();
            //}
        }
    }
}
