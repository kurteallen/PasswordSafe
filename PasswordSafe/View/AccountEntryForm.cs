using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSafe.Model;



namespace PasswordSafe
{
    public partial class AccountEntryView : Form
    {

        ///public event AddAccount addAccount;
        private Boolean isAnEdit = false;
        private Accounts acc;
        private Encryption en = new Encryption();

        public AccountEntryView()
        {
            InitializeComponent();
            this.Text = "Add Account";
            saveBTN.Enabled = false;
            isAnEdit = false;
        }

        //This is the edit constructor
        public AccountEntryView(Accounts a)
        {
            InitializeComponent();
            
                this.Text = "Edit Account";
                this.AccountTxtBox.Text = a.Account;
                this.userNameTxtBox.Text = a.UserName;
                this.passwordTxtBox.Text = a.Password;
                this.notesTxtBox.Text = a.Notes;
                this.acc = a;
                this.isAnEdit = true;
                saveBTN.PerformClick();
            
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            //Creating a boolean that determines the entry point to this method
            //True if the method was accessed via the save button
            //False  if the method was accessed  through the Edit button
            //or by cliking on one of the items in the list box window
            //Execute accordingly
            if (!this.isAnEdit)
            {
                Accounts a = new Accounts(AccountTxtBox.Text.Trim(), userNameTxtBox.Text, passwordTxtBox.Text, notesTxtBox.Text.Trim());
                if (SingletonList.Instance.MyContains(a.Account))
                    MessageBox.Show("Account already exists");

                else
                {
                    SingletonList.Instance.GetList.Add(a);
                    en.EncryptAndSerialize(SingletonList.Instance.PassText, SingletonList.Instance.GetList);
                    this.Close();  
                }
            }
            else //I am here through editing of account
            {
                // if the account name that was passed from the parent window
                // equals what is typed in the current account box text
                // then remove the account and add the new info (easier than finding the index
                // and then changing the attributes for that object.

                if (AccountTxtBox.Text.ToLower().Trim().Equals(this.acc.Account.ToLower().Trim()))
                {
                    SingletonList.Instance.GetList.Remove(acc);
                    SingletonList.Instance.GetList.Add(new Accounts(AccountTxtBox.Text.Trim(), userNameTxtBox.Text, passwordTxtBox.Text, notesTxtBox.Text.Trim()));
                    this.Close();
                }

                // If the account name of what the user typed exist in the list
                // then show a message box
                else if (SingletonList.Instance.MyContains(AccountTxtBox.Text.Trim()))
                {
                    MessageBox.Show("Account already exists");
                }
                
                // If the account name of what the user typed does not exist in the list
                // then add it
                else
                {
                    SingletonList.Instance.GetList.Add(new Accounts(AccountTxtBox.Text.Trim(), userNameTxtBox.Text, passwordTxtBox.Text, notesTxtBox.Text.Trim()));
                    this.Close();
                }
            }
        }

        private void AccountEntryView_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (AccountTxtBox.Text.Trim().Equals(String.Empty))
                saveBTN.Enabled = false;
            else
                saveBTN.Enabled = true;
        }     
    }
}
