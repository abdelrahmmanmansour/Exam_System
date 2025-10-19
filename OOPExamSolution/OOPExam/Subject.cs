using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
	public class Subject
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }
        public Subject()
        {
            
        }
        public Subject(int Id , string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void CreateExam()
        {
            int examType, time, numOfQuestions;
            do
            {
                Console.WriteLine("Please Enter Exam Type --> 1 For Practical , 2 For Final");
            } while (!(int.TryParse(Console.ReadLine(), out examType) && (examType is 1 or 2)));
            do
            {
				Console.WriteLine("Please Enter The Time For Exam");
			}while(!(int.TryParse(Console.ReadLine(), out time)) && (time > 0));
            do
            {
                Console.WriteLine("Please Enter The Num Of Questions For Exam");
            } while (!(int.TryParse(Console.ReadLine(),out numOfQuestions) && (numOfQuestions > 0)));
            if (examType == 1)
            {
				SubjectExam = new PracticalExam(time, numOfQuestions);
            }
            else
            {
				SubjectExam = new FinalExam(time, numOfQuestions);
            }
            Console.Clear();
			SubjectExam.CreateListOfQuestions();
		}
    }
}
