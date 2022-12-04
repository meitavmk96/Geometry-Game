namespace finalproject
{
    partial class frmGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblTitle.Location = new System.Drawing.Point(424, 142);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "!משחק נגמר";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblPoints.Location = new System.Drawing.Point(630, 247);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(67, 31);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = ":ניקוד";
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.Color.Linen;
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(503, 245);
            this.txtPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPoints.Size = new System.Drawing.Size(114, 34);
            this.txtPoints.TabIndex = 2;
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPractice.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.ForeColor = System.Drawing.Color.Transparent;
            this.btnPractice.Location = new System.Drawing.Point(519, 368);
            this.btnPractice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(129, 90);
            this.btnPractice.TabIndex = 3;
            this.btnPractice.Text = "תרגול טעויות עבר";
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStartOver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartOver.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.ForeColor = System.Drawing.Color.Transparent;
            this.btnStartOver.Location = new System.Drawing.Point(824, 368);
            this.btnStartOver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(129, 90);
            this.btnStartOver.TabIndex = 4;
            this.btnStartOver.Text = "התחל משחק חדש";
            this.btnStartOver.UseVisualStyleBackColor = false;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnError.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnError.ForeColor = System.Drawing.Color.Transparent;
            this.btnError.Location = new System.Drawing.Point(364, 368);
            this.btnError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(129, 90);
            this.btnError.TabIndex = 5;
            this.btnError.Text = "צפה בטעויות";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnTryAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTryAgain.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.ForeColor = System.Drawing.Color.Transparent;
            this.btnTryAgain.Location = new System.Drawing.Point(673, 368);
            this.btnTryAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(129, 90);
            this.btnTryAgain.TabIndex = 6;
            this.btnTryAgain.Text = "נסה שנית";
            this.btnTryAgain.UseVisualStyleBackColor = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Transparent;
            this.btnMain.Location = new System.Drawing.Point(211, 368);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(129, 90);
            this.btnMain.TabIndex = 7;
            this.btnMain.Text = "חזור לתפריט הראשי";
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources.BG6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 631);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.Shown += new System.EventHandler(this.frmGameOver_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnMain;
    }
}