using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
	public class Answer
	{
        public int Id { get; set; }
        public string Text { get; set; }
        public Answer(int Id , string Text)
        {
            this.Id = Id;
            this.Text = Text;
        }
        public Answer()
        {
            
        }
		public override string ToString()
		{
			return $"  {Id}) {Text}";
		}
	}
}
