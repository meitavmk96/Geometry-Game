using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class BoolPicQue : BaseQuestion
    {
        public BoolPicQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer) :
            this(question, questionImage, correctAnswer, inCorrectAnswer, true)
        {
        }

        private BoolPicQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer, bool addQNumberToImage) :
            base(question, questionImage, correctAnswer, inCorrectAnswer, addQNumberToImage)
        {
            if (addQNumberToImage)//Add the question number to the name of the image
            {
                CorrectAnswer = QNumber + correctAnswer;
                InCorrectAnswer = QNumber + inCorrectAnswer;
            }
            else//Data coming from the file already contains the question number there is no need to add it
            {
                CorrectAnswer = correctAnswer;
                InCorrectAnswer = inCorrectAnswer;
            }
        }

        public override Qtype Type => Qtype.boolPicQue;

        internal static BaseQuestion CreateFromData(string[] parts)
        {
            return new BoolPicQue(parts[QuestionIndex], parts[QuestionImageIndex], parts[CorrectAnsIndex], parts[InCorrectAns1], false);
        }
    }
}
