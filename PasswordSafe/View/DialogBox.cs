using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSafe.Model;
using PasswordSafe.View;

namespace PasswordSafe
{
    public partial class DialogBox : Form
    {
        private Encryption en = new Encryption();
        public DialogBox()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("about to launch");
                // retrieve encrypted password, compare against typed password.
                // if correct then open list, otherwise show dialog box stating
                // password incorrect and try again.
                
                if (en.VerifyPassword(this.passwordEntryTextBX.Text))
                {

                    SingletonList.Instance.PassText = passwordEntryTextBX.Text;
                    en.DecryptAndUnSerialize(this.passwordEntryTextBX.Text);
                    this.Hide();
                    AcntList accountList = new AcntList();
                    accountList.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                    passwordEntryTextBX.Clear();
                }

        }

        private void DialogBox_Load(object sender, EventArgs e)
        {
            
        }
    }
}
