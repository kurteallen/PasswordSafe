using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            //First password must be at least 6 characters
            //Passwords cannot be empty
            if (passBox1.Text.Length > 6 || passBox2.Text.Length > 6)
                if(!passBox1.Text.Equals(string.Empty) || !passBox1.Text.Equals(string.Empty))
                    if(passBox1.Text.Equals(passBox2.Text))
                    {
                        if (en.StoreNewPassword(passBox1.Text))
                        {
                        MessageBox.Show("Password Changed");
                        SingletonList.Instance.PassText = passBox1.Text;
                        en.EncryptAndSerialize(SingletonList.Instance.PassText, SingletonList.Instance.GetList);
                        }
                        else
                        MessageBox.Show("Password Not Changed");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Password Don't Match");   
                else
                    MessageBox.Show("Password cannot be empty");
            else
                MessageBox.Show("Password must be at\n least 6 characters");
            passBox1.Clear();
            passBox2.Clear();
        } 

            

        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
