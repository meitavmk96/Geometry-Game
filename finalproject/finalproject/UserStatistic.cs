using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    public class UserStatistic
    {
        const int userNameIndex = 0;
        const int mailIndex = 1;
        const int gameTimeInSecondsIndex = 2;
        const int numOfCurrectAnsIndex = 3;
        const int numOfInCurrectAnsIndex = 4;
        const int scoreIndex = 5;
        const int wrongQueNumsIndex = 6;

        public UserStatistic(string userName, string mail, long gameTimeInSeconds, int numOfCurrectAns, int numOfInCurrectAns, int score, List<int> wrongQueNums)
        {
            //All statistical items of the user
            UserName = userName;
            Mail = mail;
            GameTimeInSeconds = gameTimeInSeconds;
            NumOfCurrectAns = numOfCurrectAns;
            NumOfInCurrectAns = numOfInCurrectAns;
            Score = score;
            WrongQueNums = wrongQueNums;
        }

        public string UserName { get; }
        public string Mail { get; }
        public long GameTimeInSeconds { get; }
        public int NumOfCurrectAns { get; }
        public int NumOfInCurrectAns { get; }
        public int Score { get; }
        public List<int> WrongQueNums { get; }

        internal List<string> GetData()//File format
        {
            List<string> lines = new List<string>();
            lines.Add(UserName);
            lines.Add(Mail);
            lines.Add(GameTimeInSeconds.ToString());
            lines.Add(NumOfCurrectAns.ToString());
            lines.Add(NumOfInCurrectAns.ToString());
            lines.Add(Score.ToString());
            lines.Add(string.Join(",", WrongQueNums));
            return lines;
        }

        internal static UserStatistic CreateFromData(string[] parts)//Create an object for the file data
        {
            return new UserStatistic(parts[userNameIndex], parts[mailIndex], int.Parse(parts[gameTimeInSecondsIndex]), int.Parse(parts[numOfCurrectAnsIndex]), int.Parse(parts[numOfInCurrectAnsIndex]), int.Parse(parts[scoreIndex]), GetWrongQuestionNums(parts[wrongQueNumsIndex]));
        }

        static List<int> GetWrongQuestionNums(string str)//Inserts questions numbers into an intiger's array to save all the questions the user answered wrong
        {
            List<int> res = new List<int>();
            if (!string.IsNullOrEmpty(str))
            {
                string[] items = str.Split(',');
                foreach (string item in items)
                    res.Add(int.Parse(item));
            }
            return res;
        }
    }
}
