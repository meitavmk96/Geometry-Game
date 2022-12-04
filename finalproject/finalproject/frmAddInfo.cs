using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class frmAddInfo : Form
    {
        public string Topic { get { return cmb.Text; } }
        public string Content { get { return txtContent.Text; } }
        public string ImageName { get; private set; }

        public frmAddInfo()
        {
            InitializeComponent();
            cmb.SelectedIndex = 0;//sets default item type
        }

        private void btnAddInfo_Click(object sender, EventArgs e)//Checks that all fields for adding an item of information are complete
        {
            bool allFilled = !string.IsNullOrEmpty(txtContent.Text);
            if (!allFilled)
            {
                MessageBox.Show("יש למלא את כל השדות");
                DialogResult = DialogResult.None;
            }
            else
                DialogResult = DialogResult.OK;
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//if button choose pic clicked open file window
                ImageName = openFileDialog1.FileName;//save the choosen image name from dialog
        }

        private void chkPic_CheckedChanged(object sender, EventArgs e)//if check box is not checked choose image option is Visible and sets image name null
        {
            btnPic.Visible = chkPic.Checked;
            ImageName = null;
        }

        private void txtContent_KeyPress(object sender, KeyPressEventArgs e)//Does not allow a semicolon
        {
            if (e.KeyChar == ';')
                e.Handled = true;
        }
    }
}
