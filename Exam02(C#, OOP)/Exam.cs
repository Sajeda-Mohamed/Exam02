using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C___OOP_
{
    internal abstract class Exam
    {
        public DateTime TimeoOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public Exam() { }   
        public Exam(DateTime timeoOfExam, int numberOfQuestions)
        {
            TimeoOfExam = timeoOfExam;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
        }
        public abstract void ShowExam();  
        public abstract void ReceiveExam();
    }
}
