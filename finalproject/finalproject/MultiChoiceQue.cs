using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class MultiChoiceQue : BaseQuestion
    {

        public MultiChoiceQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer, string inCorrectAnswer2, string inCorrectAnswer3) :
           this(question, questionImage, correctAnswer, inCorrectAnswer, inCorrectAnswer2, inCorrectAnswer3, true)
        {
        }
        private MultiChoiceQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer, string inCorrectAnswer2, string inCorrectAnswer3, bool addQNumberToImage) :
            base(question, questionImage, correctAnswer, inCorrectAnswer, addQNumberToImage)
        {
            InCorrectAnswer2 = inCorrectAnswer2;
            IncorrectAnswer3 = inCorrectAnswer3;
        }

        public string InCorrectAnswer2 { get; set; }
        public string IncorrectAnswer3 { get; set; }

        public override Qtype Type => Qtype.MultiChoiceQue;

        public override string ToString()//File writing format
        {
            return base.ToString() + $";{InCorrectAnswer2};{IncorrectAnswer3}";
        }

        internal static BaseQuestion CreateFromData(string[] parts)//Create an object from the file data
        {
            return new MultiChoiceQue(parts[QuestionIndex], parts[QuestionImageIndex], parts[CorrectAnsIndex], parts[InCorrectAns1], parts[InCorrectAns2], parts[InCorrectAns3], false); ;
        }
    }
}
