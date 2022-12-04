using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class frmGameOver : Form
    {
        const int QueCount = 10;//number of questions 
        const int QuestionScore = 10;//score for each question
        bool showGame = true;//if true display the quiz automatically when opening the screen

        List<PlayData> gamePlayData = new List<PlayData>();//List of questions and answers of the current game and of the Try-again-game for the user
        public List<BaseQuestion> Questions { get; }//List of all the questions in the system
        public string UserName { get; }
        public string Mail { get; }

        private List<UserStatistic> UserStatistics;//current user statistics

        public frmGameOver()
        {
            InitializeComponent();
        }

        public frmGameOver(List<BaseQuestion> questions, string userName, string mail, List<UserStatistic> userStatistics) :
            this()
        {
            Questions = questions;
            UserName = userName;
            Mail = mail;
            UserStatistics = userStatistics;
        }

        private void btnStartOver_Click(object sender, EventArgs e)//start new game
        {
            List<BaseQuestion> randQuestions = CreateRandomQuestions(Questions);//choose 10 questions randomly

            gamePlayData.Clear();
            foreach (BaseQuestion question in randQuestions)//Creating game data according to the number of questions
                gamePlayData.Add(new PlayData(question));

            frmQuiz frm = new frmQuiz(gamePlayData);
            Stopwatch sw = new Stopwatch();
            sw.Start();//time counter
            if (frm.ShowDialog() == DialogResult.OK)
            {
                sw.Stop();
                UpdateScore(gamePlayData);//Update the score
                SaveUserStatistic(sw.ElapsedMilliseconds / 100);//saves statistics
            }
            else
                DialogResult = DialogResult.Cancel;
        }

        private void SaveUserStatistic(long gameTimeInSeconds)//saves statistics
        {
            //collects data for statistics
            int numOfCurrectAns = 0;
            int numOfInCurrectAns = 0;
            List<int> wrongQueNums = new List<int>();
            foreach (var item in gamePlayData)
            {
                if (item.IsCorrrectAnswer)//counts the number of correct answers
                    numOfCurrectAns++;
                else
                {
                    numOfInCurrectAns++;//counts the number of incorrect answers
                    wrongQueNums.Add(item.Question.QNumber);//Question number for incorrect answer
                }
            }
            int score = numOfCurrectAns * QuestionScore;//Score calculation
            UserStatistic userStatistic = new UserStatistic(UserName, Mail, gameTimeInSeconds, numOfCurrectAns, numOfInCurrectAns, score, wrongQueNums);//Create a statistic record for the user
            UserStatistics.Add(userStatistic);//add to main list

            string fileName = $"{UserName}_{DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}";//Build file by user and quiz date
            fileName = fileName.Replace(":", "_");
            if (!Directory.Exists(frmMain.PlayerDirName))//if folder dosent exist create folder
                Directory.CreateDirectory(frmMain.PlayerDirName);
            string filePath = Path.Combine(frmMain.PlayerDirName, fileName);
            File.WriteAllLines(filePath, userStatistic.GetData());//Save to the user's file
        }

        private void UpdateScore(List<PlayData> gamePlayData)//Update Score display
        {
            int score = GetScore(gamePlayData);
            txtPoints.Text = score.ToString();
        }

        private int GetScore(List<PlayData> gamePlayData)//Score calculation
        {
            int numOfCurrectAns = 0;
            foreach (var item in gamePlayData)
            {
                if (item.IsCorrrectAnswer)
                    numOfCurrectAns++;
            }
            int score = numOfCurrectAns * QuestionScore;
            return score;
        }

        private void btnTryAgain_Click(object sender, EventArgs e)//try again (without saving the answer to the questions)
        {
            List<PlayData> copyPlayData = new List<PlayData>();
            foreach (var item in gamePlayData)
                copyPlayData.Add(new PlayData(item.Question));
            frmQuiz frm = new frmQuiz(copyPlayData);//if true dont save game data 
            if (frm.ShowDialog() == DialogResult.OK)
                UpdateScore(copyPlayData);
        }

        private void btnPractice_Click(object sender, EventArgs e)//Practice the wrong answers that the user answered before (even in the distant past from the statistics)
        {
            Dictionary<int, object> unique = new Dictionary<int, object>();//using dictionary of unique number so that the random questions would not be repeated

            //the wrong answers from the last-current game
            List<PlayData> wrongPlayData = new List<PlayData>();
            foreach (PlayData playData in gamePlayData)
                if (!playData.IsCorrrectAnswer)
                {
                    wrongPlayData.Add(new PlayData(playData.Question));
                    unique.Add(playData.Question.QNumber, null);
                }
            //the wrong answers from distant past games
            List<int> wrongs = new List<int>();
            foreach (var item in UserStatistics)
                wrongs.AddRange(item.WrongQueNums);
            foreach (int wrongQ in wrongs)
            {
                if (!unique.ContainsKey(wrongQ))
                {
                    BaseQuestion question = GetQuertionByNum(wrongQ);
                    if (question != null)
                    {
                        wrongPlayData.Add(new PlayData(question));
                        unique.Add(question.QNumber, null);
                    }
                }
            }
            //If we did not find any question with an incorrect answer a message is given accordingly
            if (wrongPlayData.Count == 0)
            {
                MessageBox.Show("אתה תותח! עוד לא עשית טעויות");
                return;
            }

            frmQuiz frm = new frmQuiz(wrongPlayData);
            frm.ShowDialog();
        }

        private BaseQuestion GetQuertionByNum(int quetionNum)//Returns the question by the number of the question
        {
            foreach (var item in Questions)
            {
                if (item.QNumber == quetionNum)
                    return item;
            }
            return null;
        }

        private void btnError_Click(object sender, EventArgs e)//displays all the questions in which the user answered a wrong answer 
        {

            List<PlayData> wrongPlayData = new List<PlayData>();
            foreach (PlayData playData in gamePlayData)
                if (!playData.IsCorrrectAnswer)
                    wrongPlayData.Add(playData);
            if (wrongPlayData.Count == 0)
            {
                MessageBox.Show("אתה תותח! עוד לא עשית טעויות");
                return;
            }
            frmShowAnswer frm = new frmShowAnswer(wrongPlayData);
            frm.ShowDialog();
        }

        public static List<BaseQuestion> CreateRandomQuestions(List<BaseQuestion> questions)//Creating a random list of random new questions
        {
            Random random = new Random();
            List<BaseQuestion> RandQuestions = new List<BaseQuestion>();
            int length = Math.Min(questions.Count, QueCount);
            do
            {
                int index = random.Next(0, questions.Count - 1);
                BaseQuestion dataItem = questions[index];
                if (!RandQuestions.Contains(dataItem))
                    RandQuestions.Add(dataItem);
            }
            while (RandQuestions.Count < length);
            return RandQuestions;
        }

        private void frmGameOver_Shown(object sender, EventArgs e)//Opening the window for the first time from the main window and reopening the game
        {
            if (showGame)
                btnStartOver_Click(sender, e);
            showGame = false;
        }
    }
}
