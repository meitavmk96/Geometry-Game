using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class frmMain : Form
    {
        const string QuestionFileName = "gameData.txt";
        const string InfoFileName = "infoData.txt";
        const string DataDirName = "DATA";
        public const string ImageDirName = "DIMAGES";
        public const string QuetionImageDirName = "QIMAGES";
        public const string PlayerDirName = "PLAYERS";

        List<DataItem> dataItems = new List<DataItem>();// Create a list of information items
        List<BaseQuestion> questions = new List<BaseQuestion>();// Create a list of questions
        Dictionary<string, List<UserStatistic>> playerStatitics = new Dictionary<string, List<UserStatistic>>(StringComparer.OrdinalIgnoreCase); //List of user statistics by user name

        string userName;
        string mail;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadUsersStatics();

            frmLogin frm = new frmLogin(playerStatitics);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                userName = frm.UserName;
                mail = frm.Mail;

                LoadInfo();// a function that loads info items from text file
                LoadQuestions();// a function that loads questions items from text file
            }
            else
                Close();
        }
        private void LoadUsersStatics()//loads statistics by username
        {
            if (Directory.Exists(PlayerDirName))
            {
                string[] files = Directory.GetFiles(PlayerDirName);//reads all statistic files list 
                foreach (var file in files)
                {
                    string[] lines = File.ReadAllLines(file);// Reads entire file and creates array of rows
                    UserStatistic userStatistic = UserStatistic.CreateFromData(lines);//Create a user statistic object from the file data
                    if (!playerStatitics.ContainsKey(userStatistic.UserName))//if user dosent exist in dictionery 
                        playerStatitics.Add(userStatistic.UserName, new List<UserStatistic>());//create empty list
                    playerStatitics[userStatistic.UserName].Add(userStatistic);//add user statistics to list
                }
            }
        }

        private void LoadQuestions()
        {
            string filePath = Path.Combine(DataDirName, QuestionFileName);// Chains a name for the file location
            if (File.Exists(filePath))// If the file exists read the lines in the file
            {
                string[] allLines = File.ReadAllLines(filePath);// Creates an array of lines from the file 
                foreach (string line in allLines)// creates an object in the list of question data for each line
                {
                    if (string.IsNullOrEmpty(line))
                        continue;
                    BaseQuestion question = BaseQuestion.CreateFromData(line);//create question object from file data
                    questions.Add(question);
                }
            }
        }

        private void LoadInfo()
        {
            string filePath = Path.Combine(DataDirName, InfoFileName);// Chains a name for the file location
            if (File.Exists(filePath))// If the file exists read the lines in the file 
            {
                string[] allLines = File.ReadAllLines(filePath);// Creates an array of lines from the file 
                foreach (string line in allLines)// creates an object in the list of info data for each line
                {
                    if (string.IsNullOrEmpty(line))
                        continue;
                    DataItem dataItem = DataItem.CreateFromData(line);// method that turns string to DataItem
                    dataItems.Add(dataItem);
                }
            }
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            DataItem dataitem = null;
            frmAddInfo frm = new frmAddInfo();
            if (frm.ShowDialog() == DialogResult.OK)//Displays the Add Item window and returns information from it by clicking OK
            {
                try
                {
                    if (string.IsNullOrEmpty(frm.ImageName))//checks if pic with or without image
                        dataitem = new DataItem(frm.Topic, frm.Content);//if item dosent have image save as no image item
                    else
                        dataitem = new DataItemWImage(frm.Topic, frm.Content, Path.GetFileName(frm.ImageName));//if item has image save as image item
                    foreach (var item in dataItems)//checks is Data item already exists and displays a suitable message 
                    {
                        if (item.CompareTo(dataitem) == 0)
                        {
                            DataItem.DecreaseUniqueNumber();
                            MessageBox.Show("פריט מידע זה קיים");
                            return;
                        }
                    }
                    if (!string.IsNullOrEmpty(frm.ImageName))//copy image to DIMAGES folder
                        CopyImage(frm.ImageName, ImageDirName, (dataitem as DataItemWImage).Image);
                    if (!Directory.Exists(DataDirName))//if folder dosent exist create folder
                        Directory.CreateDirectory(DataDirName);
                    string filePath = Path.Combine(DataDirName, InfoFileName);//chains name for file location
                    File.AppendAllText(filePath, dataitem.ToString() + "\r\n");//adds item to the end of the file
                    dataItems.Add(dataitem);//adds item to list items
                    dataitem = null;
                    MessageBox.Show("פריט מידע התווסף בהצלחה");
                }
                catch (Exception ex)
                {
                    if (dataitem != null)
                        DataItem.DecreaseUniqueNumber();
                    MessageBox.Show($"{ex.Message} הוספת פריט מידע נכשלה:");
                }
            }
        }

        private static void CopyImage(string sourcePath, string imageDir, string destinationFileName)//copy to DIMAGES
        {
            string destinationPath = Path.Combine(imageDir, destinationFileName);//chains name for image destination location
            if (!Directory.Exists(imageDir))//if destination folder doesnt exist create folder
                Directory.CreateDirectory(imageDir);
            File.Copy(sourcePath, destinationPath);// copy image from current folder to destination --> DIMAGES
        }

        private void btnAddQue_Click(object sender, EventArgs e)
        {
            BaseQuestion question = null;
            frmAddQue frm = new frmAddQue();
            if (frm.ShowDialog() == DialogResult.OK)//Displays the Add question window by clicking OK
            {
                try
                {
                    switch (frm.QType)//Displays relevant inboxes according to question type
                    {
                        case Qtype.boolQue:
                            question = new BoolQue(frm.Question, GetFileName(frm.QuestionImage), frm.CorrectAnswer, frm.InCorrectAnswer);
                            if (IsExists(question)) //checks is question already exists and displays a suitable message
                            {
                                BaseQuestion.DecreaseUniqueNumber();
                                MessageBox.Show("שאלה קיימת");
                                return;
                            }
                            break;
                        case Qtype.boolPicQue:
                            question = new BoolPicQue(frm.Question, GetFileName(frm.QuestionImage), GetFileName(frm.CorrectAnswer), GetFileName(frm.InCorrectAnswer));
                            if (IsExists(question)) //checks is question already exists and displays a suitable message
                            {
                                BaseQuestion.DecreaseUniqueNumber();
                                MessageBox.Show("שאלה קיימת");
                                return;
                            }
                            CopyImage(frm.CorrectAnswer, QuetionImageDirName, question.CorrectAnswer);
                            CopyImage(frm.InCorrectAnswer, QuetionImageDirName, (question as BoolPicQue).InCorrectAnswer);
                            break;
                        case Qtype.MultiChoiceQue:
                            question = new MultiChoiceQue(frm.Question, GetFileName(frm.QuestionImage), GetFileName(frm.CorrectAnswer), GetFileName(frm.InCorrectAnswer),
                                GetFileName(frm.InCorrectAnswer2), GetFileName(frm.InCorrectAnswer3));
                            if (IsExists(question)) //checks is question already exists and displays a suitable message
                            {
                                BaseQuestion.DecreaseUniqueNumber();
                                MessageBox.Show("שאלה קיימת");
                                return;
                            }
                            break;
                        case Qtype.MultiChoicePicQue:
                            question = new MultiChoicePicQue(frm.Question, GetFileName(frm.QuestionImage), GetFileName(frm.CorrectAnswer), GetFileName(frm.InCorrectAnswer),
                                 GetFileName(frm.InCorrectAnswer2), GetFileName(frm.InCorrectAnswer3));
                            if (IsExists(question)) //checks is question already exists and displays a suitable message
                            {
                                BaseQuestion.DecreaseUniqueNumber();
                                MessageBox.Show("שאלה קיימת");
                                return;
                            }
                            CopyImage(frm.CorrectAnswer, QuetionImageDirName, question.CorrectAnswer);
                            CopyImage(frm.InCorrectAnswer, QuetionImageDirName, (question as MultiChoicePicQue).InCorrectAnswer);
                            CopyImage(frm.InCorrectAnswer2, QuetionImageDirName, (question as MultiChoicePicQue).InCorrectAnswer2);
                            CopyImage(frm.InCorrectAnswer3, QuetionImageDirName, (question as MultiChoicePicQue).InCorrectAnswer3);
                            break;
                    }
                    if (!string.IsNullOrEmpty(frm.QuestionImage))//if question has image copy image name
                        CopyImage(frm.QuestionImage, QuetionImageDirName, question.QuestionImage);

                    if (!Directory.Exists(DataDirName))//if folder dosent exist create folder
                        Directory.CreateDirectory(DataDirName);
                    string filePath = Path.Combine(DataDirName, QuestionFileName);//chains name for file location
                    File.AppendAllText(filePath, question.ToString() + "\r\n");// add question to the end of the file 
                    questions.Add(question);// add question to list 
                    question = null;
                    MessageBox.Show("שאלה התווספה בהצלחה");
                }
                catch (Exception ex)
                {
                    if (question != null)
                        BaseQuestion.DecreaseUniqueNumber();
                    MessageBox.Show($"{ex.Message} :הוספת שאלה נכשלה ");
                }
            }
        }

        bool IsExists(BaseQuestion question)
        {
            foreach (var item in questions)//checks is question already exists and displays a suitable message 
            {
                if (item.CompareTo(question) == 0)
                    return true;
            }
            return false;
        }
        private string GetFileName(string imagePath)//finds file name by file address
        {
            if (!string.IsNullOrEmpty(imagePath))
                return Path.GetFileName(imagePath);
            return imagePath;
        }

        private void btnStartTutorial_Click(object sender, EventArgs e)
        {
            frmTutorial frm = new frmTutorial(dataItems);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(" סיימת ללמוד");
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)//opens new game automatically from frmGameOver
        {
            List<UserStatistic> currentUserStatistics;
            if (!playerStatitics.TryGetValue(userName, out currentUserStatistics))
                currentUserStatistics = new List<UserStatistic>();
            frmGameOver frm1 = new frmGameOver(questions, userName, mail, currentUserStatistics);
            frm1.ShowDialog();
        }
    }
}
