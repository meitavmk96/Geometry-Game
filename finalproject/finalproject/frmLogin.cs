using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class frmLogin : Form
    {
        public string UserName { get { return txtPlayer.Text; } }
        public string Mail { get { return txtMail.Text; } }

        public Dictionary<string, List<UserStatistic>> PlayerStatitics { get; }

        public frmLogin()
        {
            InitializeComponent();
            ActiveControl = txtPlayer;
        }

        public frmLogin(Dictionary<string, List<UserStatistic>> playerStatitics) : this()//Statistics data of all users
        {
            PlayerStatitics = playerStatitics;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)//Does not allow a enter
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
                e.Handled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrEmpty(txtPlayer.Text) && !string.IsNullOrEmpty(txtMail.Text);//fills all fields
            if (!allFilled)
            {
                MessageBox.Show("יש למלא את כל השדות");
                DialogResult = DialogResult.None;
                return;
            }
            bool isMaileValid = Regex.IsMatch(txtMail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);//Email validation
            if (!isMaileValid)
            {
                MessageBox.Show("כתובת דואר לא תקינה");
                DialogResult = DialogResult.None;
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void txtPlayer_KeyUp(object sender, KeyEventArgs e)//automatically fills Email if username already exists
        {
            List<UserStatistic> userStatistics;
            if (PlayerStatitics.TryGetValue(txtPlayer.Text, out userStatistics) && userStatistics.Count > 0)
            {
                txtMail.Text = userStatistics[0].Mail;
                txtMail.Enabled = false;
            }
            else
            {
                if (txtMail.Enabled == false)
                    txtMail.Text = "";
                txtMail.Enabled = true;
            }
        }
    }
}
