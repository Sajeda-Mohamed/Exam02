using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C___OOP_
{
    internal class PracticalExam : Exam
    { 
        public PracticalExam() { }
        public PracticalExam(DateTime timeoOfExam, int numberOfQuestions) : base(timeoOfExam, numberOfQuestions)
        { }
        public override void ShowExam()
        {
            Question question = new Question();

        }
        public override void ReceiveExam()
        {
            Question question = new Question();
            question.ReceiveMCQQuestions(1);
        }
    }
}
