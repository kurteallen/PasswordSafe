namespace PasswordSafe.View
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.passBox1 = new System.Windows.Forms.TextBox();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.errorOne = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTwo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // passBox1
            // 
            this.passBox1.Location = new System.Drawing.Point(112, 14);
            this.passBox1.Name = "passBox1";
            this.passBox1.PasswordChar = '*';
            this.passBox1.Size = new System.Drawing.Size(139, 20);
            this.passBox1.TabIndex = 0;
            this.passBox1.UseSystemPasswordChar = true;
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(112, 43);
            this.passBox2.Name = "passBox2";
            this.passBox2.PasswordChar = '*';
            this.passBox2.Size = new System.Drawing.Size(139, 20);
            this.passBox2.TabIndex = 1;
            this.passBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Re-enter Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(8, 77);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 4;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(176, 77);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // errorOne
            // 
            this.errorOne.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorOne.ContainerControl = this;
            this.errorOne.RightToLeft = true;
            // 
            // errorTwo
            // 
            this.errorTwo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTwo.ContainerControl = this;
            this.errorTwo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTwo.Icon")));
            this.errorTwo.RightToLeft = true;
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(262, 112);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.passBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passBox1;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ErrorProvider errorOne;
        private System.Windows.Forms.ErrorProvider errorTwo;
    }
}