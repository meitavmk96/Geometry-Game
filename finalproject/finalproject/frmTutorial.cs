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
    public partial class frmTutorial : Form
    {
        int CurrentIndex = 0;// index of current info item
        const int numOfQuestions = 12;
        internal List<DataItem> RandDataItems = new List<DataItem>();//list of random info items

        public frmTutorial()
        {
            InitializeComponent();
            ActiveControl = btnNext;
        }

        public frmTutorial(List<DataItem> dataItems) : this()
        {
            CreateRandomList(dataItems);
            FillTutorial();
        }

        private void CreateRandomList(List<DataItem> dataItems)//choose randomly 12 info items from the list
        {
            Random random = new Random();
            int length = Math.Min(dataItems.Count, numOfQuestions); // calculate the number of random info items
            do
            {
                int index = random.Next(0, dataItems.Count);
                DataItem dataItem = dataItems[index];
                if (!RandDataItems.Contains(dataItem))
                    RandDataItems.Add(dataItem);
            }
            while (RandDataItems.Count < length);
        }

        private void FillTutorial()//fills screen by current item location 
        {
            DataItem dataItem = RandDataItems[CurrentIndex];
            txtTopic.Text = dataItem.Topic;
            txtContent.Text = dataItem.Content;
            if (dataItem is DataItemWImage)
            {
                string imagePath = Path.Combine(frmMain.ImageDirName, (dataItem as DataItemWImage).Image);
                pbxImage.Load(imagePath);
                pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                pbxImage.Image = null;
        }

        private void btnNext_Click(object sender, EventArgs e)// move towards the next info item
        {
            if (CurrentIndex == RandDataItems.Count - 1)
                DialogResult = DialogResult.OK;
            else
            {
                CurrentIndex++;
                FillTutorial();
            }
        }
    }
}
