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
    public partial class frmAddQue : Form
    {
        public Qtype QType { get { return (Qtype)cbxType.SelectedIndex; } }
        public string Question { get { return txtQue.Text; } }
        public string QuestionImage { get { return txtQimage.Text; } }
        public string CorrectAnswer { get { return txtCorrectAns.Text; } }
        public string InCorrectAnswer { get { return txtInCorrectAns1.Text; } }
        public string InCorrectAnswer2 { get { return txtInCorrectAns2.Text; } }
        public string InCorrectAnswer3 { get { return txtInCorrectAns3.Text; } }

        public frmAddQue()
        {
            InitializeComponent();
            cbxType.SelectedIndex = 0;//Default for the question type
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxType.SelectedIndex)   //sets visible property for lbl and txt boxs
            {
                case 0: //single 
                    lblIncorrectAns2.Visible = false;
                    lblIncorrectAns3.Visible = false;

                    txtInCorrectAns2.Visible = false;
                    txtInCorrectAns3.Visible = false;
                    txtInCorrectAns1.Enabled = true;
                    txtInCorrectAns2.Enabled = true;
                    txtInCorrectAns3.Enabled = true;
                    txtCorrectAns.Enabled = true;

                    btnCorrectImage.Visible = false;

                    btnImage1.Visible = false;
                    btnImage2.Visible = false;
                    btnImage3.Visible = false;
                    break;
                case 2: //single + image
                    lblIncorrectAns2.Visible = false;
                    lblIncorrectAns3.Visible = false;

                    txtInCorrectAns2.Visible = false;
                    txtInCorrectAns3.Visible = false;
                    txtInCorrectAns1.Enabled = false;
                    txtInCorrectAns2.Enabled = false;
                    txtInCorrectAns3.Enabled = false;
                    txtCorrectAns.Enabled = false;

                    btnCorrectImage.Visible = true;

                    btnImage1.Visible = true;
                    btnImage2.Visible = false;
                    btnImage3.Visible = false;
                    break;
                case 1: // multi
                    lblIncorrectAns2.Visible = true;
                    lblIncorrectAns3.Visible = true;

                    txtInCorrectAns2.Visible = true;
                    txtInCorrectAns3.Visible = true;
                    txtInCorrectAns1.Enabled = true;
                    txtInCorrectAns2.Enabled = true;
                    txtInCorrectAns3.Enabled = true;
                    txtCorrectAns.Enabled = true;

                    btnCorrectImage.Visible = false;

                    btnImage1.Visible = false;
                    btnImage2.Visible = false;
                    btnImage3.Visible = false;
                    break;
                case 3: // multi + image
                    lblIncorrectAns2.Visible = true;
                    lblIncorrectAns3.Visible = true;

                    txtInCorrectAns2.Visible = true;
                    txtInCorrectAns3.Visible = true;
                    txtInCorrectAns1.Enabled = false;
                    txtInCorrectAns2.Enabled = false;
                    txtInCorrectAns3.Enabled = false;
                    txtCorrectAns.Enabled = false;

                    btnCorrectImage.Visible = true;

                    btnImage1.Visible = true;
                    btnImage2.Visible = true;
                    btnImage3.Visible = true;
                    break;
            }
        }

        private void btnCorrectImage_Click(object sender, EventArgs e)//Picture for the correct answer
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtCorrectAns.Text = openFileDialog1.FileName;
        }

        private void btnImage1_Click(object sender, EventArgs e)//Picture for the first wrong answer
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtInCorrectAns1.Text = openFileDialog1.FileName;
        }

        private void btnImage2_Click(object sender, EventArgs e)//Picture for the second wrong answer
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtInCorrectAns2.Text = openFileDialog1.FileName;
        }

        private void btnImage3_Click(object sender, EventArgs e)//Picture for the third incorrect answer
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtInCorrectAns3.Text = openFileDialog1.FileName;
        }

        private void btnQimage_Click(object sender, EventArgs e)//Picture for question 
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtQimage.Text = openFileDialog1.FileName;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)//Does not allow a semicolon
        {
            if (e.KeyChar == ';')
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)//Check that all the fields for adding a question are filled according to the question type
        {
            bool allFilled = !string.IsNullOrEmpty(txtQue.Text) &&
                !string.IsNullOrEmpty(txtCorrectAns.Text) &&
                !string.IsNullOrEmpty(txtInCorrectAns1.Text);
            if (txtInCorrectAns2.Visible)
                allFilled = allFilled && !string.IsNullOrEmpty(txtInCorrectAns2.Text);
            if (txtInCorrectAns3.Visible)
                allFilled = allFilled && !string.IsNullOrEmpty(txtInCorrectAns3.Text);
            if (!allFilled)
            {
                MessageBox.Show("יש למלא את כל השדות");
                DialogResult = DialogResult.None;
                return;
            }

            if (HasDuplicateImage())
            {
                MessageBox.Show("יש תמונות כפולות"); 
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private bool HasDuplicateImage()
        {
            string imageName;

            Dictionary<string, object> unique = new Dictionary<string, object>();//If the user enters the same image multiple times for the same question (in the answers)

            if (!string.IsNullOrEmpty(txtQimage.Text))
            {
                imageName = Path.GetFileName(txtQimage.Text);
                unique.Add(imageName, null);
            }

            switch (QType)
            {
                case Qtype.boolPicQue:
                    imageName = Path.GetFileName(txtCorrectAns.Text);
                    if (unique.ContainsKey(imageName))
                        return true;
                    unique.Add(imageName, null);
                    imageName = Path.GetFileName(txtInCorrectAns1.Text);
                    if (unique.ContainsKey(imageName))
                        return true;
                    break;
                case Qtype.MultiChoicePicQue:
                    imageName = Path.GetFileName(txtCorrectAns.Text);
                    if (unique.ContainsKey(imageName))
                        return true;
                    unique.Add(imageName, null);
                    imageName = Path.GetFileName(txtInCorrectAns1.Text);
                    if (unique.ContainsKey(imageName))
                        return true;
                    unique.Add(imageName, null);
                    imageName = Path.GetFileName(txtInCorrectAns2.Text);
                    if (unique.ContainsKey(imageName))
                        return true;
                    unique.Add(imageName, null);
                    imageName = Path.GetFileName(txtInCorrectAns3.Text);
                    if (unique.ContainsKey(imageName))
                        return true;
                    break;
            }
            return false;
        }
    }
}
