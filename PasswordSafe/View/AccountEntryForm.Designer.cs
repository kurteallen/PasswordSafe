namespace PasswordSafe
{
    partial class AccountEntryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountEntryView));
            this.AccountTxtBox = new System.Windows.Forms.TextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.notesTxtBox = new System.Windows.Forms.TextBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountTxtBox
            // 
            this.AccountTxtBox.Location = new System.Drawing.Point(67, 13);
            this.AccountTxtBox.MaxLength = 100;
            this.AccountTxtBox.Name = "AccountTxtBox";
            this.AccountTxtBox.Size = new System.Drawing.Size(211, 20);
            this.AccountTxtBox.TabIndex = 0;
            this.AccountTxtBox.TextChanged += new System.EventHandler(this.AccountTxtBox_TextChanged);
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(67, 38);
            this.userNameTxtBox.MaxLength = 33;
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(211, 20);
            this.userNameTxtBox.TabIndex = 1;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(67, 64);
            this.passwordTxtBox.MaxLength = 33;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(211, 20);
            this.passwordTxtBox.TabIndex = 2;
            // 
            // notesTxtBox
            // 
            this.notesTxtBox.Location = new System.Drawing.Point(67, 90);
            this.notesTxtBox.Multiline = true;
            this.notesTxtBox.Name = "notesTxtBox";
            this.notesTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTxtBox.Size = new System.Drawing.Size(211, 131);
            this.notesTxtBox.TabIndex = 3;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(67, 227);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(203, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Location = new System.Drawing.Point(4, 17);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(47, 13);
            this.accountName.TabIndex = 7;
            this.accountName.Text = "Account";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(4, 42);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(60, 13);
            this.userNameLbl.TabIndex = 8;
            this.userNameLbl.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // AccountEntryView
            // 
            this.AcceptButton = this.saveBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(286, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.notesTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.AccountTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountEntryView";
            this.Text = "Edit Account";
            this.Load += new System.EventHandler(this.AccountEntryView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountTxtBox;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox notesTxtBox;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label label4;
    }
}