using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    public class PlayData
    {
        const int CorrectAnswerIndex = 0;//index of the correct answer
        const int AnsBool = 2;//number of answers for truth or false question
        const int AnsMulti = 4;//number of answers for multi-choice question

        public BaseQuestion Question { get; }
        public int[] AnswerPlace { get; set; }
        public int Answer { get; set; }
        public bool IsCorrrectAnswer
        {
            get
            {
                //if variable Answer is correct answer return true
                if (Answer >= 0 && Answer < AnswerPlace.Length)
                    return AnswerPlace[Answer] == CorrectAnswerIndex;
                return false;
            }
        }

        public PlayData(BaseQuestion question)//Creates game data from the question and builds a random answer location
        {
            Random random = new Random();
            Question = question;
            switch (question.Type)
            {
                case Qtype.boolQue:
                case Qtype.boolPicQue:
                    AnswerPlace = new int[AnsBool];
                    FillRandomAnswers(random);
                    break;
                case Qtype.MultiChoiceQue:
                case Qtype.MultiChoicePicQue:
                    AnswerPlace = new int[AnsMulti];
                    FillRandomAnswers(random);
                    break;
            }
        }

        private void FillRandomAnswers(Random random)//builds a random questions location
        {
            Dictionary<int, object> unique = new Dictionary<int, object>();//Do not add to the list if the question already exists according to the unique number

            for (int i = 0; i < AnswerPlace.Length; i++)
            {
                do
                {
                    AnswerPlace[i] = random.Next(0, AnswerPlace.Length);
                } while (unique.ContainsKey(AnswerPlace[i]));
                unique.Add(AnswerPlace[i], null);
            }
        }

    }
}
