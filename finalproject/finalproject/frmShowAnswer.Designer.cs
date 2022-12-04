namespace finalproject
{
    partial class frmShowAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowAnswer));
            this.lblQue = new System.Windows.Forms.Label();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.pbQue = new System.Windows.Forms.PictureBox();
            this.pbAns1 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQue
            // 
            this.lblQue.AutoSize = true;
            this.lblQue.BackColor = System.Drawing.Color.Transparent;
            this.lblQue.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQue.Location = new System.Drawing.Point(697, 78);
            this.lblQue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQue.Name = "lblQue";
            this.lblQue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQue.Size = new System.Drawing.Size(69, 32);
            this.lblQue.TabIndex = 0;
            this.lblQue.Text = "שאלה";
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(405, 137);
            this.txtQue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQue.Multiline = true;
            this.txtQue.Name = "txtQue";
            this.txtQue.ReadOnly = true;
            this.txtQue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQue.Size = new System.Drawing.Size(441, 54);
            this.txtQue.TabIndex = 1;
            // 
            // txtAns1
            // 
            this.txtAns1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns1.Location = new System.Drawing.Point(405, 268);
            this.txtAns1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAns1.Multiline = true;
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.ReadOnly = true;
            this.txtAns1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAns1.Size = new System.Drawing.Size(441, 54);
            this.txtAns1.TabIndex = 2;
            // 
            // pbQue
            // 
            this.pbQue.BackColor = System.Drawing.Color.Transparent;
            this.pbQue.Location = new System.Drawing.Point(193, 78);
            this.pbQue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbQue.Name = "pbQue";
            this.pbQue.Size = new System.Drawing.Size(186, 113);
            this.pbQue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQue.TabIndex = 14;
            this.pbQue.TabStop = false;
            // 
            // pbAns1
            // 
            this.pbAns1.BackColor = System.Drawing.Color.Transparent;
            this.pbAns1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAns1.Location = new System.Drawing.Point(592, 268);
            this.pbAns1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAns1.Name = "pbAns1";
            this.pbAns1.Size = new System.Drawing.Size(186, 136);
            this.pbAns1.TabIndex = 15;
            this.pbAns1.TabStop = false;
            this.pbAns1.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Linen;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(84, 286);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 72);
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
            this.btnClose.Location = new System.Drawing.Point(84, 383);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 69);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblCurrentAnswer
            // 
            this.lblCurrentAnswer.AutoSize = true;
            this.lblCurrentAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentAnswer.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAnswer.Location = new System.Drawing.Point(611, 214);
            this.lblCurrentAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentAnswer.Name = "lblCurrentAnswer";
            this.lblCurrentAnswer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentAnswer.Size = new System.Drawing.Size(155, 32);
            this.lblCurrentAnswer.TabIndex = 21;
            this.lblCurrentAnswer.Text = "התשובה הנכונה";
            // 
            // frmShowAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources.BG5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 588);
            this.Controls.Add(this.lblCurrentAnswer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbAns1);
            this.Controls.Add(this.pbQue);
            this.Controls.Add(this.txtAns1);
            this.Controls.Add(this.txtQue);
            this.Controls.Add(this.lblQue);
            this.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQue;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.PictureBox pbQue;
        private System.Windows.Forms.PictureBox pbAns1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrentAnswer;
    }
}