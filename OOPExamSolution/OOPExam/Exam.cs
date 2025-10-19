using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
	public abstract class Exam
	{
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Exam()
        {
            
        }
        public Exam(int Time , int NumOfQuestions)
        {
            this.Time = Time;
            this.NumOfQuestions = NumOfQuestions;
        }
        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();
    }
}
