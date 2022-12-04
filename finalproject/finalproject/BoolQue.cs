using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class BoolQue : BaseQuestion
    {
        public BoolQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer) :
            this(question, questionImage, correctAnswer, inCorrectAnswer, true)
        {

        }
        private BoolQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer, bool addQNumberToImage) :
            base(question, questionImage, correctAnswer, inCorrectAnswer, addQNumberToImage)
        {

        }

        public override Qtype Type => Qtype.boolQue;

        internal static BaseQuestion CreateFromData(string[] parts)
        {
            return new BoolQue(parts[QuestionIndex], parts[QuestionImageIndex], parts[CorrectAnsIndex], parts[InCorrectAns1], false);
        }
    }
}
