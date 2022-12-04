namespace finalproject
{
    partial class frmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.lblQue = new System.Windows.Forms.Label();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.txtAns4 = new System.Windows.Forms.TextBox();
            this.pbQue = new System.Windows.Forms.PictureBox();
            this.pbAns1 = new System.Windows.Forms.PictureBox();
            this.pbAns3 = new System.Windows.Forms.PictureBox();
            this.pbAns4 = new System.Windows.Forms.PictureBox();
            this.pbAns2 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.radPic4 = new System.Windows.Forms.RadioButton();
            this.radPic3 = new System.Windows.Forms.RadioButton();
            this.radPic2 = new System.Windows.Forms.RadioButton();
            this.radPic1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQue
            // 
            this.lblQue.AutoSize = true;
            this.lblQue.BackColor = System.Drawing.Color.Transparent;
            this.lblQue.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQue.Location = new System.Drawing.Point(646, 89);
            this.lblQue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQue.Name = "lblQue";
            this.lblQue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQue.Size = new System.Drawing.Size(251, 38);
            this.lblQue.TabIndex = 0;
            this.lblQue.Text = "ענה על השאלה הבאה:";
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(465, 130);
            this.txtQue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQue.Multiline = true;
            this.txtQue.Name = "txtQue";
            this.txtQue.ReadOnly = true;
            this.txtQue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQue.Size = new System.Drawing.Size(425, 52);
            this.txtQue.TabIndex = 1;
            // 
            // txtAns1
            // 
            this.txtAns1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns1.Location = new System.Drawing.Point(465, 197);
            this.txtAns1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAns1.Multiline = true;
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.ReadOnly = true;
            this.txtAns1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAns1.Size = new System.Drawing.Size(414, 55);
            this.txtAns1.TabIndex = 2;
            // 
            // txtAns3
            // 
            this.txtAns3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns3.Location = new System.Drawing.Point(465, 340);
            this.txtAns3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAns3.Multiline = true;
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.ReadOnly = true;
            this.txtAns3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAns3.Size = new System.Drawing.Size(414, 48);
            this.txtAns3.TabIndex = 3;
            // 
            // txtAns2
            // 
            this.txtAns2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns2.Location = new System.Drawing.Point(465, 271);
            this.txtAns2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAns2.Multiline = true;
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.ReadOnly = true;
            this.txtAns2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAns2.Size = new System.Drawing.Size(414, 47);
            this.txtAns2.TabIndex = 4;
            // 
            // txtAns4
            // 
            this.txtAns4.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns4.Location = new System.Drawing.Point(465, 412);
            this.txtAns4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAns4.Multiline = true;
            this.txtAns4.Name = "txtAns4";
            this.txtAns4.ReadOnly = true;
            this.txtAns4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAns4.Size = new System.Drawing.Size(414, 49);
            this.txtAns4.TabIndex = 5;
            // 
            // pbQue
            // 
            this.pbQue.BackColor = System.Drawing.Color.Transparent;
            this.pbQue.Location = new System.Drawing.Point(258, 45);
            this.pbQue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbQue.Name = "pbQue";
            this.pbQue.Size = new System.Drawing.Size(199, 137);
            this.pbQue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQue.TabIndex = 14;
            this.pbQue.TabStop = false;
            // 
            // pbAns1
            // 
            this.pbAns1.BackColor = System.Drawing.Color.Transparent;
            this.pbAns1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAns1.Location = new System.Drawing.Point(680, 196);
            this.pbAns1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAns1.Name = "pbAns1";
            this.pbAns1.Size = new System.Drawing.Size(177, 137);
            this.pbAns1.TabIndex = 15;
            this.pbAns1.TabStop = false;
            this.pbAns1.Visible = false;
            // 
            // pbAns3
            // 
            this.pbAns3.BackColor = System.Drawing.Color.Transparent;
            this.pbAns3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAns3.Location = new System.Drawing.Point(680, 339);
            this.pbAns3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAns3.Name = "pbAns3";
            this.pbAns3.Size = new System.Drawing.Size(177, 137);
            this.pbAns3.TabIndex = 16;
            this.pbAns3.TabStop = false;
            this.pbAns3.Visible = false;
            // 
            // pbAns4
            // 
            this.pbAns4.BackColor = System.Drawing.Color.Transparent;
            this.pbAns4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAns4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAns4.Location = new System.Drawing.Point(280, 339);
            this.pbAns4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAns4.Name = "pbAns4";
            this.pbAns4.Size = new System.Drawing.Size(177, 137);
            this.pbAns4.TabIndex = 17;
            this.pbAns4.TabStop = false;
            this.pbAns4.Visible = false;
            // 
            // pbAns2
            // 
            this.pbAns2.BackColor = System.Drawing.Color.Transparent;
            this.pbAns2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAns2.Location = new System.Drawing.Point(280, 196);
            this.pbAns2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAns2.Name = "pbAns2";
            this.pbAns2.Size = new System.Drawing.Size(177, 137);
            this.pbAns2.TabIndex = 18;
            this.pbAns2.TabStop = false;
            this.pbAns2.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Linen;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(50, 327);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 78);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "המשך";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Linen;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(50, 417);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 79);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(887, 204);
            this.rad1.Margin = new System.Windows.Forms.Padding(4);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(21, 20);
            this.rad1.TabIndex = 21;
            this.rad1.TabStop = true;
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(887, 417);
            this.rad4.Margin = new System.Windows.Forms.Padding(4);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(21, 20);
            this.rad4.TabIndex = 22;
            this.rad4.TabStop = true;
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(887, 278);
            this.rad2.Margin = new System.Windows.Forms.Padding(4);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(21, 20);
            this.rad2.TabIndex = 23;
            this.rad2.TabStop = true;
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(887, 347);
            this.rad3.Margin = new System.Windows.Forms.Padding(4);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(21, 20);
            this.rad3.TabIndex = 24;
            this.rad3.TabStop = true;
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // radPic4
            // 
            this.radPic4.AutoSize = true;
            this.radPic4.Location = new System.Drawing.Point(465, 395);
            this.radPic4.Margin = new System.Windows.Forms.Padding(4);
            this.radPic4.Name = "radPic4";
            this.radPic4.Size = new System.Drawing.Size(21, 20);
            this.radPic4.TabIndex = 25;
            this.radPic4.TabStop = true;
            this.radPic4.UseVisualStyleBackColor = true;
            // 
            // radPic3
            // 
            this.radPic3.AutoSize = true;
            this.radPic3.Location = new System.Drawing.Point(869, 389);
            this.radPic3.Margin = new System.Windows.Forms.Padding(4);
            this.radPic3.Name = "radPic3";
            this.radPic3.Size = new System.Drawing.Size(21, 20);
            this.radPic3.TabIndex = 26;
            this.radPic3.TabStop = true;
            this.radPic3.UseVisualStyleBackColor = true;
            // 
            // radPic2
            // 
            this.radPic2.AutoSize = true;
            this.radPic2.Location = new System.Drawing.Point(465, 260);
            this.radPic2.Margin = new System.Windows.Forms.Padding(4);
            this.radPic2.Name = "radPic2";
            this.radPic2.Size = new System.Drawing.Size(21, 20);
            this.radPic2.TabIndex = 27;
            this.radPic2.TabStop = true;
            this.radPic2.UseVisualStyleBackColor = true;
            // 
            // radPic1
            // 
            this.radPic1.AutoSize = true;
            this.radPic1.Location = new System.Drawing.Point(869, 260);
            this.radPic1.Margin = new System.Windows.Forms.Padding(4);
            this.radPic1.Name = "radPic1";
            this.radPic1.Size = new System.Drawing.Size(21, 20);
            this.radPic1.TabIndex = 28;
            this.radPic1.TabStop = true;
            this.radPic1.UseVisualStyleBackColor = true;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources.BG5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 588);
            this.Controls.Add(this.radPic1);
            this.Controls.Add(this.radPic2);
            this.Controls.Add(this.radPic3);
            this.Controls.Add(this.radPic4);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbAns2);
            this.Controls.Add(this.pbAns4);
            this.Controls.Add(this.pbAns3);
            this.Controls.Add(this.pbAns1);
            this.Controls.Add(this.pbQue);
            this.Controls.Add(this.txtAns4);
            this.Controls.Add(this.txtAns2);
            this.Controls.Add(this.txtAns3);
            this.Controls.Add(this.txtAns1);
            this.Controls.Add(this.txtQue);
            this.Controls.Add(this.lblQue);
            this.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQue;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.TextBox txtAns4;
        private System.Windows.Forms.PictureBox pbQue;
        private System.Windows.Forms.PictureBox pbAns1;
        private System.Windows.Forms.PictureBox pbAns3;
        private System.Windows.Forms.PictureBox pbAns4;
        private System.Windows.Forms.PictureBox pbAns2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton radPic4;
        private System.Windows.Forms.RadioButton radPic3;
        private System.Windows.Forms.RadioButton radPic2;
        private System.Windows.Forms.RadioButton radPic1;
    }
}