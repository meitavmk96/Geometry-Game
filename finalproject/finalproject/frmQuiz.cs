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
    public partial class frmQuiz : Form
    {
        int CurrentIndex = 0;
        const int AnsIndex1 = 0;
        const int AnsIndex2 = 1;
        const int AnsIndex3 = 2;
        const int AnsIndex4 = 3;
        const int NoAns = -1;

        List<PlayData> gamePlayData = new List<PlayData>();//List of question and it's answer's data

        public frmQuiz()
        {
            InitializeComponent();
            ActiveControl = btnNext;
        }

        public frmQuiz(List<PlayData> gamePlayData) : this()//List of random questions that will be presented to the user
        {
            this.gamePlayData = gamePlayData;
            FillQuestion();
        }

        private void FillQuestion()//Fill in a question for the screen
        {
            PlayData playData = gamePlayData[CurrentIndex];
            BaseQuestion question = playData.Question;
            txtQue.Text = question.Question;

            if (!string.IsNullOrEmpty(question.QuestionImage))
                pbQue.Load(Path.Combine(frmMain.QuetionImageDirName, question.QuestionImage));
            else
                pbQue.Image = null;
            switch (question.Type)//Hiding controls by question type
            {
                case Qtype.boolQue:
                    txtAns1.Visible = true;
                    txtAns2.Visible = true;
                    txtAns3.Visible = false;
                    txtAns4.Visible = false;

                    rad1.Visible = true;
                    rad2.Visible = true;
                    rad3.Visible = false;
                    rad4.Visible = false;

                    pbAns1.Visible = false;
                    pbAns2.Visible = false;
                    pbAns3.Visible = false;
                    pbAns4.Visible = false;

                    radPic1.Visible = false;
                    radPic2.Visible = false;
                    radPic3.Visible = false;
                    radPic4.Visible = false;

                    txtAns1.Text = GetAnswer(AnsIndex1, playData);
                    txtAns2.Text = GetAnswer(AnsIndex2, playData);
                    break;
                case Qtype.MultiChoiceQue:

                    txtAns1.Visible = true;
                    txtAns2.Visible = true;
                    txtAns3.Visible = true;
                    txtAns4.Visible = true;

                    rad1.Visible = true;
                    rad2.Visible = true;
                    rad3.Visible = true;
                    rad4.Visible = true;

                    pbAns1.Visible = false;
                    pbAns2.Visible = false;
                    pbAns3.Visible = false;
                    pbAns4.Visible = false;

                    radPic1.Visible = false;
                    radPic2.Visible = false;
                    radPic3.Visible = false;
                    radPic4.Visible = false;

                    txtAns1.Text = GetAnswer(AnsIndex1, playData);
                    txtAns2.Text = GetAnswer(AnsIndex2, playData);
                    txtAns3.Text = GetAnswer(AnsIndex3, playData);
                    txtAns4.Text = GetAnswer(AnsIndex4, playData);
                    break;
                case Qtype.boolPicQue:

                    txtAns1.Visible = false;
                    txtAns2.Visible = false;
                    txtAns3.Visible = false;
                    txtAns4.Visible = false;

                    rad1.Visible = false;
                    rad2.Visible = false;
                    rad3.Visible = false;
                    rad4.Visible = false;

                    pbAns1.Visible = true;
                    pbAns2.Visible = true;
                    pbAns3.Visible = false;
                    pbAns4.Visible = false;

                    radPic1.Visible = true;
                    radPic2.Visible = true;
                    radPic3.Visible = false;
                    radPic4.Visible = false;

                    pbAns1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAns2.SizeMode = PictureBoxSizeMode.StretchImage;

                    pbAns1.Load(Path.Combine(frmMain.QuetionImageDirName, GetAnswer(AnsIndex1, playData)));
                    pbAns2.Load(Path.Combine(frmMain.QuetionImageDirName, GetAnswer(AnsIndex2, playData)));
                    break;
                case Qtype.MultiChoicePicQue:

                    txtAns1.Visible = false;
                    txtAns2.Visible = false;
                    txtAns3.Visible = false;
                    txtAns4.Visible = false;

                    rad1.Visible = false;
                    rad2.Visible = false;
                    rad3.Visible = false;
                    rad4.Visible = false;

                    pbAns1.Visible = true;
                    pbAns2.Visible = true;
                    pbAns3.Visible = true;
                    pbAns4.Visible = true;

                    radPic1.Visible = true;
                    radPic2.Visible = true;
                    radPic3.Visible = true;
                    radPic4.Visible = true;

                    pbAns1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAns2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAns3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAns4.SizeMode = PictureBoxSizeMode.StretchImage;

                    pbAns1.Load(Path.Combine(frmMain.QuetionImageDirName, GetAnswer(AnsIndex1, playData)));
                    pbAns2.Load(Path.Combine(frmMain.QuetionImageDirName, GetAnswer(AnsIndex2, playData)));
                    pbAns3.Load(Path.Combine(frmMain.QuetionImageDirName, GetAnswer(AnsIndex3, playData)));
                    pbAns4.Load(Path.Combine(frmMain.QuetionImageDirName, GetAnswer(AnsIndex4, playData)));
                    break;
                default:
                    break;
            }
            rad1.Checked = false;
            rad2.Checked = false;
            rad3.Checked = false;
            rad4.Checked = false;
            radPic1.Checked = false;
            radPic2.Checked = false;
            radPic3.Checked = false;
            radPic4.Checked = false;
        }

        private string GetAnswer(int index, PlayData playData)//returns answer by random location
        {
            int position = playData.AnswerPlace[index];//finds answer's position
            switch (position)
            {
                case AnsIndex1: return playData.Question.CorrectAnswer;
                case AnsIndex2: return playData.Question.InCorrectAnswer;
                case AnsIndex3:
                    if (playData.Question is MultiChoiceQue)
                        return (playData.Question as MultiChoiceQue).InCorrectAnswer2;
                    if (playData.Question is MultiChoicePicQue)
                        return (playData.Question as MultiChoicePicQue).InCorrectAnswer2;
                    break;
                case AnsIndex4:
                    if (playData.Question is MultiChoiceQue)
                        return (playData.Question as MultiChoiceQue).IncorrectAnswer3;
                    if (playData.Question is MultiChoicePicQue)
                        return (playData.Question as MultiChoicePicQue).InCorrectAnswer3;
                    break;
            }
            throw new Exception("תשובה לא נמצאה");
        }

        private void btnNext_Click(object sender, EventArgs e)//move on to the next question
        {
            if (GetUserAnswer() == NoAns)//If the user did not answer
            {
                MessageBox.Show("אנא בחר תשובה");
                return;
            }
            if (CurrentIndex == gamePlayData.Count - 1)//If we have reached the end of the quiz go back to the previous screen
                DialogResult = DialogResult.OK;
            else
            {
                gamePlayData[CurrentIndex].Answer = GetUserAnswer();//move on to the next question
                CurrentIndex++;
                FillQuestion();
            }
        }

        private int GetUserAnswer()//returns the correct answer by radio button and question type
        {
            PlayData playData = gamePlayData[CurrentIndex];
            switch (playData.Question.Type)
            {
                case Qtype.boolQue:
                    if (rad1.Checked)
                        return AnsIndex1;
                    if (rad2.Checked)
                        return AnsIndex2;
                    break;
                case Qtype.boolPicQue:
                    if (radPic1.Checked)
                        return AnsIndex1;
                    if (radPic2.Checked)
                        return AnsIndex2;
                    break;
                case Qtype.MultiChoiceQue:
                    if (rad1.Checked)
                        return AnsIndex1;
                    if (rad2.Checked)
                        return AnsIndex2;
                    if (rad3.Checked)
                        return AnsIndex3;
                    if (rad4.Checked)
                        return AnsIndex4;
                    break;
                case Qtype.MultiChoicePicQue:
                    if (radPic1.Checked)
                        return AnsIndex1;
                    if (radPic2.Checked)
                        return AnsIndex2;
                    if (radPic3.Checked)
                        return AnsIndex3;
                    if (radPic4.Checked)
                        return AnsIndex4;
                    break;
            }
            return NoAns;
        }
    }
}
