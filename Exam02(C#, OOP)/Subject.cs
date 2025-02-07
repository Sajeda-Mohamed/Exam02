using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C___OOP_
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }

        public Subject(int subjectId, string subjectName, Exam examOfSubject)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            ExamOfSubject = examOfSubject;
        }
        
    }
}
