using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
	public class PracticalExam : Exam
	{
        public PracticalExam(int time , int numOfQuestions) : base(time,numOfQuestions)
        {
            
        }
        public override void CreateListOfQuestions()
		{
			Questions = new MCQQuestion[NumOfQuestions];
			for(int i = 0; i < Questions?.Length; i++)
			{
				Questions[i] = new MCQQuestion();
				Questions[i].AddQuestion();
			}
			Console.Clear();
		}

		public override void ShowExam()
		{
			foreach(var question in Questions)
			{
				Console.WriteLine(question);
				for(int i = 0; i < question.Answers.Length; i++)
				{
					Console.WriteLine(question.Answers[i]);
				}
				Console.WriteLine("*************************");
				int userAnswerId;
				do
				{
					Console.WriteLine("Please Enter the right answer Id");
				} while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));
				question.UserAnswer.Id = userAnswerId;
				question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;
			}
			Console.Clear();
			Console.WriteLine("Right Answers For Practical Exam");
			for(int i = 0; i < Questions?.Length; i++)
			{
				Console.WriteLine($"{i+1}) : {Questions[i].Body}");
				Console.WriteLine($"Right Answer --> {Questions[i].RightAnswer.Text}");
				Console.WriteLine("***************************");
			}
		}
	}
}
