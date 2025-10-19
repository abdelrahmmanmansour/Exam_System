using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
	public class FinalExam : Exam
	{
        public FinalExam(int time , int numberOfQuestions) : base(time,numberOfQuestions)
        {
            
        }
        public override void CreateListOfQuestions()
		{
			Questions = new Question[NumOfQuestions];
			for(int i = 0; i < Questions?.Length; i++)
			{
				int choice;
				do
				{
					Console.WriteLine("Please Enter Your Choice 1 For MCQ , 2 For T/F");
				} while (!(int.TryParse(Console.ReadLine(), out choice) && (choice is 1 or 2)));
				Console.WriteLine();
				if(choice == 1)
				{
					Questions[i] = new MCQQuestion();
					Questions[i].AddQuestion();
				}
				else
				{
					Questions[i] = new TFQuestion();
					Questions[i].AddQuestion();
				}
			}
		}

		public override void ShowExam()
		{
			foreach(var question in  Questions) 
			{
				Console.WriteLine(question);
				for (int i = 0; i < question.Answers.Length; i++)
					Console.WriteLine(question.Answers[i]);
				int userAnswerId; 
				if(question?.GetType() == typeof(MCQQuestion))
				{
					do
					{
						Console.WriteLine("Please Enter the right answer Id");
					} while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));
				}
				else
				{
					do
					{
						Console.WriteLine("Please Enter the right answer Id 1 For True and 2 For False");
					} while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2)));
				}
				question.UserAnswer.Id = userAnswerId;
				question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;
			}
			Console.Clear();
			int grade = 0, totalMarks = 0;
			for(int i = 0; i < Questions?.Length; i++)
			{
				totalMarks += Questions[i].Mark;
				if (Questions[i].UserAnswer.Id == Questions[i].RightAnswer.Id)
				{
					grade += Questions[i].Mark;
				}
				Console.WriteLine($"{i + 1}) : {Questions[i].Body}");
				Console.WriteLine($"Your Answer --> {Questions[i].UserAnswer.Text}");
				Console.WriteLine($"Right Answer --> {Questions[i].RightAnswer.Text}");
				Console.WriteLine("***************************");
			}
			Console.WriteLine($"Your Grade is {grade} out of {totalMarks}");
		
		}
	}
}
