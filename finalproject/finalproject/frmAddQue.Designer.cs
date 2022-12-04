
namespace finalproject
{
    partial class frmAddQue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQue));
            this.lblQue = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.txtCorrectAns = new System.Windows.Forms.TextBox();
            this.lblIncorrectAns1 = new System.Windows.Forms.Label();
            this.txtInCorrectAns1 = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblIncorrectAns2 = new System.Windows.Forms.Label();
            this.txtInCorrectAns2 = new System.Windows.Forms.TextBox();
            this.lblIncorrectAns3 = new System.Windows.Forms.Label();
            this.txtInCorrectAns3 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImage1 = new System.Windows.Forms.Button();
            this.btnImage2 = new System.Windows.Forms.Button();
            this.btnImage3 = new System.Windows.Forms.Button();
            this.btnQimage = new System.Windows.Forms.Button();
            this.btnCorrectImage = new System.Windows.Forms.Button();
            this.txtQimage = new System.Windows.Forms.TextBox();
            this.lblQimage = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQue
            // 
            this.lblQue.AutoSize = true;
            this.lblQue.BackColor = System.Drawing.Color.Transparent;
            this.lblQue.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQue.Location = new System.Drawing.Point(817, 307);
            this.lblQue.Name = "lblQue";
            this.lblQue.Size = new System.Drawing.Size(66, 30);
            this.lblQue.TabIndex = 0;
            this.lblQue.Text = "שאלה";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.BackColor = System.Drawing.Color.Transparent;
            this.lblAns.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.Location = new System.Drawing.Point(817, 407);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(124, 30);
            this.lblAns.TabIndex = 1;
            this.lblAns.Text = "תשובה נכונה";
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(505, 303);
            this.txtQue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(289, 26);
            this.txtQue.TabIndex = 2;
            this.txtQue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtCorrectAns
            // 
            this.txtCorrectAns.Location = new System.Drawing.Point(503, 404);
            this.txtCorrectAns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorrectAns.Name = "txtCorrectAns";
            this.txtCorrectAns.Size = new System.Drawing.Size(289, 26);
            this.txtCorrectAns.TabIndex = 3;
            this.txtCorrectAns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblIncorrectAns1
            // 
            this.lblIncorrectAns1.AutoSize = true;
            this.lblIncorrectAns1.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrectAns1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectAns1.Location = new System.Drawing.Point(817, 470);
            this.lblIncorrectAns1.Name = "lblIncorrectAns1";
            this.lblIncorrectAns1.Size = new System.Drawing.Size(154, 30);
            this.lblIncorrectAns1.TabIndex = 4;
            this.lblIncorrectAns1.Text = "תשובה לא נכונה";
            // 
            // txtInCorrectAns1
            // 
            this.txtInCorrectAns1.Location = new System.Drawing.Point(505, 463);
            this.txtInCorrectAns1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInCorrectAns1.Name = "txtInCorrectAns1";
            this.txtInCorrectAns1.Size = new System.Drawing.Size(289, 26);
            this.txtInCorrectAns1.TabIndex = 5;
            this.txtInCorrectAns1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "שאלת אמת/שקר",
            "שאלת ריבוי בחירה",
            "שאלת אמת/שקר כאשר התשובה היא תמונה",
            "שאלת ריבוי בחירה כאשר התשובה היא תמונה"});
            this.cbxType.Location = new System.Drawing.Point(507, 233);
            this.cbxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(289, 28);
            this.cbxType.TabIndex = 6;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(817, 238);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(114, 30);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "סוג השאלה";
            // 
            // lblIncorrectAns2
            // 
            this.lblIncorrectAns2.AutoSize = true;
            this.lblIncorrectAns2.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrectAns2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectAns2.Location = new System.Drawing.Point(817, 533);
            this.lblIncorrectAns2.Name = "lblIncorrectAns2";
            this.lblIncorrectAns2.Size = new System.Drawing.Size(154, 30);
            this.lblIncorrectAns2.TabIndex = 8;
            this.lblIncorrectAns2.Text = "תשובה לא נכונה";
            this.lblIncorrectAns2.Visible = false;
            // 
            // txtInCorrectAns2
            // 
            this.txtInCorrectAns2.Location = new System.Drawing.Point(505, 524);
            this.txtInCorrectAns2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInCorrectAns2.Name = "txtInCorrectAns2";
            this.txtInCorrectAns2.Size = new System.Drawing.Size(289, 26);
            this.txtInCorrectAns2.TabIndex = 9;
            this.txtInCorrectAns2.Visible = false;
            this.txtInCorrectAns2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblIncorrectAns3
            // 
            this.lblIncorrectAns3.AutoSize = true;
            this.lblIncorrectAns3.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrectAns3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectAns3.Location = new System.Drawing.Point(817, 597);
            this.lblIncorrectAns3.Name = "lblIncorrectAns3";
            this.lblIncorrectAns3.Size = new System.Drawing.Size(154, 30);
            this.lblIncorrectAns3.TabIndex = 10;
            this.lblIncorrectAns3.Text = "תשובה לא נכונה";
            this.lblIncorrectAns3.Visible = false;
            // 
            // txtInCorrectAns3
            // 
            this.txtInCorrectAns3.Location = new System.Drawing.Point(505, 590);
            this.txtInCorrectAns3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInCorrectAns3.Name = "txtInCorrectAns3";
            this.txtInCorrectAns3.Size = new System.Drawing.Size(289, 26);
            this.txtInCorrectAns3.TabIndex = 11;
            this.txtInCorrectAns3.Visible = false;
            this.txtInCorrectAns3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(576, 152);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 57);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = ":הוסף שאלה";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Bisque;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(684, 624);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 50);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Bisque;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(508, 624);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 50);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "ביטול";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImage1
            // 
            this.btnImage1.BackColor = System.Drawing.Color.Bisque;
            this.btnImage1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImage1.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage1.Location = new System.Drawing.Point(318, 450);
            this.btnImage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImage1.Name = "btnImage1";
            this.btnImage1.Size = new System.Drawing.Size(155, 41);
            this.btnImage1.TabIndex = 15;
            this.btnImage1.Text = "בחר תמונה";
            this.btnImage1.UseVisualStyleBackColor = false;
            this.btnImage1.Click += new System.EventHandler(this.btnImage1_Click);
            // 
            // btnImage2
            // 
            this.btnImage2.BackColor = System.Drawing.Color.Bisque;
            this.btnImage2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImage2.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage2.Location = new System.Drawing.Point(318, 514);
            this.btnImage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImage2.Name = "btnImage2";
            this.btnImage2.Size = new System.Drawing.Size(155, 38);
            this.btnImage2.TabIndex = 16;
            this.btnImage2.Text = "בחר תמונה";
            this.btnImage2.UseVisualStyleBackColor = false;
            this.btnImage2.Click += new System.EventHandler(this.btnImage2_Click);
            // 
            // btnImage3
            // 
            this.btnImage3.BackColor = System.Drawing.Color.Bisque;
            this.btnImage3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImage3.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage3.Location = new System.Drawing.Point(318, 580);
            this.btnImage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImage3.Name = "btnImage3";
            this.btnImage3.Size = new System.Drawing.Size(155, 39);
            this.btnImage3.TabIndex = 17;
            this.btnImage3.Text = "בחר תמונה";
            this.btnImage3.UseVisualStyleBackColor = false;
            this.btnImage3.Click += new System.EventHandler(this.btnImage3_Click);
            // 
            // btnQimage
            // 
            this.btnQimage.BackColor = System.Drawing.Color.Bisque;
            this.btnQimage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQimage.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQimage.Location = new System.Drawing.Point(318, 340);
            this.btnQimage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQimage.Name = "btnQimage";
            this.btnQimage.Size = new System.Drawing.Size(155, 38);
            this.btnQimage.TabIndex = 20;
            this.btnQimage.Text = "בחר תמונה";
            this.btnQimage.UseVisualStyleBackColor = false;
            this.btnQimage.Click += new System.EventHandler(this.btnQimage_Click);
            // 
            // btnCorrectImage
            // 
            this.btnCorrectImage.BackColor = System.Drawing.Color.Bisque;
            this.btnCorrectImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrectImage.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectImage.Location = new System.Drawing.Point(318, 394);
            this.btnCorrectImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCorrectImage.Name = "btnCorrectImage";
            this.btnCorrectImage.Size = new System.Drawing.Size(155, 38);
            this.btnCorrectImage.TabIndex = 21;
            this.btnCorrectImage.Text = "בחר תמונה";
            this.btnCorrectImage.UseVisualStyleBackColor = false;
            this.btnCorrectImage.Click += new System.EventHandler(this.btnCorrectImage_Click);
            // 
            // txtQimage
            // 
            this.txtQimage.Enabled = false;
            this.txtQimage.Location = new System.Drawing.Point(503, 350);
            this.txtQimage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQimage.Name = "txtQimage";
            this.txtQimage.Size = new System.Drawing.Size(289, 26);
            this.txtQimage.TabIndex = 23;
            this.txtQimage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblQimage
            // 
            this.lblQimage.AutoSize = true;
            this.lblQimage.BackColor = System.Drawing.Color.Transparent;
            this.lblQimage.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQimage.Location = new System.Drawing.Point(817, 353);
            this.lblQimage.Name = "lblQimage";
            this.lblQimage.Size = new System.Drawing.Size(126, 30);
            this.lblQimage.TabIndex = 22;
            this.lblQimage.Text = "תמונת שאלה";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(525, 274);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(269, 25);
            this.lblWarning.TabIndex = 24;
            this.lblWarning.Text = "; בסעיפים הבאים אין להשתמש בסימן";
            // 
            // frmAddQue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources.BG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 845);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtQimage);
            this.Controls.Add(this.lblQimage);
            this.Controls.Add(this.btnCorrectImage);
            this.Controls.Add(this.btnQimage);
            this.Controls.Add(this.btnImage3);
            this.Controls.Add(this.btnImage2);
            this.Controls.Add(this.btnImage1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtInCorrectAns3);
            this.Controls.Add(this.lblIncorrectAns3);
            this.Controls.Add(this.txtInCorrectAns2);
            this.Controls.Add(this.lblIncorrectAns2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtInCorrectAns1);
            this.Controls.Add(this.lblIncorrectAns1);
            this.Controls.Add(this.txtCorrectAns);
            this.Controls.Add(this.txtQue);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblQue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddQue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQue;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.TextBox txtCorrectAns;
        private System.Windows.Forms.Label lblIncorrectAns1;
        private System.Windows.Forms.TextBox txtInCorrectAns1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblIncorrectAns2;
        private System.Windows.Forms.TextBox txtInCorrectAns2;
        private System.Windows.Forms.Label lblIncorrectAns3;
        private System.Windows.Forms.TextBox txtInCorrectAns3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImage1;
        private System.Windows.Forms.Button btnImage2;
        private System.Windows.Forms.Button btnImage3;
        private System.Windows.Forms.Button btnQimage;
        private System.Windows.Forms.Button btnCorrectImage;
        private System.Windows.Forms.TextBox txtQimage;
        private System.Windows.Forms.Label lblQimage;
        private System.Windows.Forms.Label lblWarning;
    }
}