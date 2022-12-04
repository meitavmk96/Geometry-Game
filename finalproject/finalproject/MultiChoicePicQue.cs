using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class MultiChoicePicQue : BaseQuestion
    {
        public MultiChoicePicQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer, string inCorrectAnswer2, string inCorrectAnswer3) :
           this(question, questionImage, correctAnswer, inCorrectAnswer, inCorrectAnswer2, inCorrectAnswer3, true)
        {
        }

        private MultiChoicePicQue(string question, string questionImage, string correctAnswer, string inCorrectAnswer, string inCorrectAnswer2, string inCorrectAnswer3, bool addQNumberToImage) :
           base(question, questionImage, correctAnswer, inCorrectAnswer, addQNumberToImage)
        {
            if (addQNumberToImage)//הוספת המספור השאלה לשם של התמונה לאותו שאלה
            {
                CorrectAnswer = QNumber + correctAnswer;
                InCorrectAnswer = QNumber + inCorrectAnswer;
                InCorrectAnswer2 = QNumber + inCorrectAnswer2;
                InCorrectAnswer3 = QNumber + inCorrectAnswer3;
            }
            else//נתוני שבאים מהקובץ מכילים כבר את המספור השאלה ולכן לא צריך להוסיף אותו
            {
                CorrectAnswer = correctAnswer;
                InCorrectAnswer = inCorrectAnswer;
                InCorrectAnswer2 = inCorrectAnswer2;
                InCorrectAnswer3 = inCorrectAnswer3;
            }
        }
        public string InCorrectAnswer2 { get; set; }
        public string InCorrectAnswer3 { get; set; }

        public override Qtype Type => Qtype.MultiChoicePicQue;

        public override string ToString()//פורמט לכתיבה
        {
            return base.ToString() + $";{InCorrectAnswer2};{InCorrectAnswer3}";
        }

        internal static BaseQuestion CreateFromData(string[] parts)//יצירת אובייקט מנתוני הקובץ
        {
           return new MultiChoicePicQue(parts[QuestionIndex], parts[QuestionImageIndex], parts[CorrectAnsIndex], parts[InCorrectAns1], parts[InCorrectAns2], parts[InCorrectAns3], false);
        }
    }
}
