
namespace finalproject
{
    partial class frmAddInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInfo));
            this.lblTopic = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkPic = new System.Windows.Forms.CheckBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.Transparent;
            this.lblTopic.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(778, 130);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(104, 29);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "נושא המידע";
            // 
            // cmb
            // 
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "משולש",
            "משולש חד-זווית",
            "משולש קהה-זווית",
            "משולש ישר-זווית",
            "משולש שווה-שוקיים",
            "משולש שווה-צלעות",
            "מרובע",
            "ריבוע",
            "מלבן",
            "מקבילית",
            "מעויין",
            "מעגל"});
            this.cmb.Location = new System.Drawing.Point(431, 132);
            this.cmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb.Name = "cmb";
            this.cmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb.Size = new System.Drawing.Size(327, 28);
            this.cmb.TabIndex = 3;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(778, 190);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(46, 29);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "תוכן";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(662, 494);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(431, 494);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "ביטול";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(429, 190);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContent.Size = new System.Drawing.Size(327, 90);
            this.txtContent.TabIndex = 2;
            this.txtContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContent_KeyPress);
            // 
            // btnPic
            // 
            this.btnPic.BackColor = System.Drawing.Color.MistyRose;
            this.btnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPic.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic.Location = new System.Drawing.Point(429, 365);
            this.btnPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPic.Name = "btnPic";
            this.btnPic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPic.Size = new System.Drawing.Size(98, 42);
            this.btnPic.TabIndex = 7;
            this.btnPic.Text = "בחר תמונה";
            this.btnPic.UseVisualStyleBackColor = false;
            this.btnPic.Visible = false;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkPic
            // 
            this.chkPic.AutoSize = true;
            this.chkPic.BackColor = System.Drawing.Color.Transparent;
            this.chkPic.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPic.Location = new System.Drawing.Point(628, 374);
            this.chkPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPic.Name = "chkPic";
            this.chkPic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPic.Size = new System.Drawing.Size(128, 33);
            this.chkPic.TabIndex = 8;
            this.chkPic.Text = "כולל תמונה";
            this.chkPic.UseVisualStyleBackColor = false;
            this.chkPic.CheckedChanged += new System.EventHandler(this.chkPic_CheckedChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(593, 284);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(163, 25);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = " ; אין להשתמש בסימן";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTitle.Location = new System.Drawing.Point(479, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 57);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = ":הוסף פריט מידע";
            // 
            // frmAddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources.BG4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 789);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.chkPic);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblTopic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkPic;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblTitle;
    }
}