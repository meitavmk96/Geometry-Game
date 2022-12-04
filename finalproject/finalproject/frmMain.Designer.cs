namespace finalproject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStartTutorial = new System.Windows.Forms.Button();
            this.btnAddQue = new System.Windows.Forms.Button();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartTutorial
            // 
            this.btnStartTutorial.BackColor = System.Drawing.Color.PeachPuff;
            this.btnStartTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartTutorial.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTutorial.Location = new System.Drawing.Point(572, 350);
            this.btnStartTutorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartTutorial.Name = "btnStartTutorial";
            this.btnStartTutorial.Size = new System.Drawing.Size(152, 68);
            this.btnStartTutorial.TabIndex = 0;
            this.btnStartTutorial.Text = "התחל ללמוד";
            this.btnStartTutorial.UseVisualStyleBackColor = false;
            this.btnStartTutorial.Click += new System.EventHandler(this.btnStartTutorial_Click);
            // 
            // btnAddQue
            // 
            this.btnAddQue.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAddQue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddQue.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQue.Location = new System.Drawing.Point(398, 350);
            this.btnAddQue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddQue.Name = "btnAddQue";
            this.btnAddQue.Size = new System.Drawing.Size(152, 68);
            this.btnAddQue.TabIndex = 1;
            this.btnAddQue.Text = "הוסף שאלה";
            this.btnAddQue.UseVisualStyleBackColor = false;
            this.btnAddQue.Click += new System.EventHandler(this.btnAddQue_Click);
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAddInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInfo.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInfo.Location = new System.Drawing.Point(223, 350);
            this.btnAddInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(152, 68);
            this.btnAddInfo.TabIndex = 2;
            this.btnAddInfo.Text = "הוסף מידע";
            this.btnAddInfo.UseVisualStyleBackColor = false;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblTitle.Location = new System.Drawing.Point(492, 208);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 54);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = ":תפריט";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.PeachPuff;
            this.btnStartQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.Location = new System.Drawing.Point(745, 350);
            this.btnStartQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(152, 68);
            this.btnStartQuiz.TabIndex = 4;
            this.btnStartQuiz.Text = "!התחל בחידון";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources.BG2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 631);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.btnAddQue);
            this.Controls.Add(this.btnStartTutorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartTutorial;
        private System.Windows.Forms.Button btnAddQue;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStartQuiz;
    }
}