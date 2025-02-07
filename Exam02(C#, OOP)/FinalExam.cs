using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C___OOP_
{
    internal class FinalExam : Exam
    {
        public FinalExam(DateTime timeoOfExam, int numberOfQuestions) : base(timeoOfExam, numberOfQuestions)
        { }
        public FinalExam() : base() { }
        public override void ShowExam()
        {
            Question question = new Question();
            //question.
        }
        public override void ReceiveExam()
        {
            Question question = new Question();
            question.ChooseQuestions(NumberOfQuestions);
        }
    }
}
