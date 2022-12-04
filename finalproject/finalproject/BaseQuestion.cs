using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    public enum Qtype { boolQue, MultiChoiceQue, boolPicQue, MultiChoicePicQue }

    public abstract class BaseQuestion : IComparable
    {
        const int TypeIndex = 1;
        protected const int QuestionIndex = 2;
        protected const int QuestionImageIndex = 3;
        protected const int CorrectAnsIndex = 4;
        protected const int InCorrectAns1 = 5;
        protected const int InCorrectAns2 = 6;
        protected const int InCorrectAns3 = 7;
        const int boolQueLength = 6;
        const int MultyChoiceQueLength = 8;


        static int questionNumber = 0;

        protected BaseQuestion(string question, string questionImage, string correctAnswer, string inCorrectAnswer, bool addQNumberToImage)
        {
            QNumber = ++questionNumber;//Unique automatic numbering for the question
            Question = question;
            if (addQNumberToImage && !string.IsNullOrEmpty(questionImage))//Checks whether to put the question number before the name of the image (if any)
                QuestionImage = QNumber + questionImage;
            else//Data from the file already contains the question numbering so there is no need to add it
                QuestionImage = questionImage;
            CorrectAnswer = correctAnswer;
            InCorrectAnswer = inCorrectAnswer;
        }

        public int QNumber { get; }
        public string Question { get; set; }
        public string QuestionImage { get; set; }
        public abstract Qtype Type { get; }
        public string CorrectAnswer { get; set; }
        public string InCorrectAnswer { get; set; }

        public int CompareTo(object obj)//Compares two questions of the same type
        {
            if (obj is BaseQuestion)
                return Question.CompareTo(((BaseQuestion)obj).Question);
            throw new Exception("Not Question");
        }

        public override string ToString()//File writing format
        {
            return $"{QNumber};{(int)this.Type};{Question};{QuestionImage};{CorrectAnswer};{InCorrectAnswer}";
        }

        internal static BaseQuestion CreateFromData(string line)//Create an object from a file row
        {
            string[] parts = line.Split(';');
            Qtype qtype = (Qtype)Enum.Parse(typeof(Qtype), parts[TypeIndex]);
            switch (qtype)
            {
                //Create an object according to the type of question
                case Qtype.boolQue:
                    if (parts.Length == boolQueLength)
                        return BoolQue.CreateFromData(parts);
                    break;
                case Qtype.MultiChoiceQue:
                    if (parts.Length == MultyChoiceQueLength)
                        return MultiChoiceQue.CreateFromData(parts);
                    break;
                case Qtype.boolPicQue:
                    if (parts.Length == boolQueLength)
                        return BoolPicQue.CreateFromData(parts);
                    break;
                case Qtype.MultiChoicePicQue:
                    if (parts.Length == MultyChoiceQueLength)
                        return MultiChoicePicQue.CreateFromData(parts);
                    break;
            }
            throw new Exception("סוג השאלה לא תקין או שמספר תכונות השאלה אינו תקין");
        }

        internal static void DecreaseUniqueNumber()//method for descending unique number in case user was added
        {
            questionNumber--;
        }
    }
}
