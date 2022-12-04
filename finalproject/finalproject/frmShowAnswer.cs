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
    public partial class frmShowAnswer : Form
    {
        int CurrentIndex = 0;// he current question index of the incorrect answers 

        List<PlayData> gamePlayData = new List<PlayData>();//list of incorrect answers


        public frmShowAnswer()
        {
            InitializeComponent();
            ActiveControl = btnNext;
        }

        public frmShowAnswer(List<PlayData> gamePlayData) : this()
        {
            this.gamePlayData = gamePlayData;
            FillQuestion();
        }



        private void FillQuestion()//Fills the screen with a correct question and answer according to the current question index
        {
            PlayData playData = gamePlayData[CurrentIndex];
            BaseQuestion question = playData.Question;
            txtQue.Text = question.Question;

            if (!string.IsNullOrEmpty(question.QuestionImage))
                pbQue.Load(Path.Combine(frmMain.QuetionImageDirName, question.QuestionImage));
            else
                pbQue.Image = null;
            switch (question.Type)//Hiding controls according to question type
            {
                case Qtype.boolQue:
                    txtAns1.Visible = true;
                    pbAns1.Visible = false;
                    txtAns1.Text = playData.Question.CorrectAnswer;
                    break;
                case Qtype.MultiChoiceQue:
                    txtAns1.Visible = true;
                    pbAns1.Visible = false;
                    txtAns1.Text = playData.Question.CorrectAnswer;
                    break;
                case Qtype.boolPicQue:
                    txtAns1.Visible = false;
                    pbAns1.Visible = true;
                    pbAns1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAns1.Load(Path.Combine(frmMain.QuetionImageDirName, playData.Question.CorrectAnswer));
                    break;
                case Qtype.MultiChoicePicQue:
                    txtAns1.Visible = false;
                    pbAns1.Visible = true;
                    pbAns1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAns1.Load(Path.Combine(frmMain.QuetionImageDirName, playData.Question.CorrectAnswer));
                    break;
                default:
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)//Move on to the following question
        {
            if (CurrentIndex == gamePlayData.Count - 1)
                DialogResult = DialogResult.OK;
            else
            {
                CurrentIndex++;
                FillQuestion();
            }
        }
    }
}
