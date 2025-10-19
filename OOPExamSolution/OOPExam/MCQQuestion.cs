using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
	public class MCQQuestion : Question
	{
		public override string Header =>"MCQ Question";
        public MCQQuestion()
        {
			Answers = new Answer[3];
        }
        public override void AddQuestion()
		{
			Console.WriteLine(Header);
			do
			{
				Console.WriteLine("Please Enter The Body Of The Question");
				Body = Console.ReadLine();
			} while (string.IsNullOrWhiteSpace(Body));
			int mark;
			do
			{
				Console.WriteLine("Please Enter The Mark Of The Question");

			} while (!(int.TryParse(Console.ReadLine(), out mark) && (mark > 0)));
			Mark = mark;
			Console.WriteLine("Choices of Mcq Questions");
			for (int i = 0; i < Answers.Length; i++)
			{
				Answers[i] = new Answer() { Id = i + 1 };
				do
				{
					Console.WriteLine($"Please Enter Choice Number {i + 1}");
					Answers[i].Text = Console.ReadLine();
				} while (string.IsNullOrWhiteSpace(Answers[i].Text));
			}
			int rightAnswerId;
			do
			{
				Console.WriteLine("Please Enter 1  , 2 , 3  for right answer ");
			} while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId is 1 or 2 or 3)));
			RightAnswer.Id = rightAnswerId;
			RightAnswer.Text = Answers[rightAnswerId - 1].Text;
			Console.Clear();
		}
	}
}
