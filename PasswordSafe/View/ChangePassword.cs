using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSafe.Model;

namespace PasswordSafe.View
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            OKBtn.Enabled = false;
            // If a file does not exist then create one
            // This means that this is the first time this
            // program has run so a datafile needs to be created
            
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
           
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {

            Encryption en = new Encryption();
            if (en.StoreNewPassword(passBox1.Text))
            {
                MessageBox.Show("Password Changed");
                SingletonList.Instance.PassText = passBox1.Text;
                en.EncryptAndSerialize(SingletonList.Instance.PassText, SingletonList.Instance.GetList);
                
            }
            else
            {
                MessageBox.Show("Password Not Changed"); 
                passBox1.Clear();
                passBox2.Clear();
            }
            this.Close();
        } 

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            string filePath = @"./filedata";

            if (!File.Exists(filePath))
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                result = MessageBox.Show("A Password Must Be Set.\n Do you want Cancel?" ,"", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    System.Environment.Exit(0);
            }
        }

        private void passBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (Regex.IsMatch(passBox1.Text, @"^[\w]{6,}"))  
                label3.Visible = false; //turn off warning
            else
                label3.Visible = true;
            
            if (passBox1.Text.Length > 5)
                label4.Visible = false;// turn off warning
            else
                label4.Visible = true;
            
            if (passBox1.Text.Equals(passBox2.Text) && !passBox1.Text.Trim().Equals(string.Empty))
                label5.Visible = false; // turn off warning
            else
                label5.Visible = true;

            if (label3.Visible == false && label4.Visible == false && label5.Visible == false)
                OKBtn.Enabled = true;
            else
                OKBtn.Enabled = false;
        }

        private void passBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (Regex.IsMatch(passBox2.Text, @"^[\w]{6,}"))
                label3.Visible = false; //turn off warning
            else
                label3.Visible = true;

            if (passBox2.Text.Length > 5)
                label4.Visible = false;// turn off warning
            else
                label4.Visible = true;

            if (passBox2.Text.Equals(passBox1.Text) && !passBox2.Text.Trim().Equals(string.Empty))
                label5.Visible = false; // turn off warning
            else
                label5.Visible = true;

            if (label3.Visible == false && label4.Visible == false && label5.Visible == false)
                OKBtn.Enabled = true;
            else
                OKBtn.Enabled = false;
        }
    }
}
