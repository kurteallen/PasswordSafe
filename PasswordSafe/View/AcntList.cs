using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSafe.Model;

namespace PasswordSafe.View
{
    public partial class AcntList : Form
    {

        private Encryption encrypt = new Encryption();
        public AcntList()
        {
            InitializeComponent();
        }

        private void AcntList_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Account";
            listBox1.DataSource = SingletonList.Instance.GetList;
            this.setButtons();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //This is child form I am going to spawn
            //It will open the Account Entry window
            AccountEntryView accountList = new AccountEntryView();
            accountList.StartPosition = FormStartPosition.Manual;
            accountList.Location = new Point(this.Left + 100, this.Top + 100);
            accountList.ShowDialog();
            this.setButtons();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            AccountEntryView accountList = new AccountEntryView((Accounts)listBox1.SelectedItem);
            accountList.StartPosition = FormStartPosition.Manual;
            accountList.Location = new Point(this.Left + 100, this.Top + 100);
            accountList.ShowDialog();
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            result = MessageBox.Show("Do you wish to delete the account " + ((Accounts)listBox1.SelectedItem).Account + "?", "Delete Account", buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SingletonList.Instance.GetList.Remove(((Accounts)listBox1.SelectedItem));
                
            }
            this.setButtons();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AccountEntryView accountList = new AccountEntryView((Accounts)listBox1.SelectedItem);
            accountList.StartPosition = FormStartPosition.Manual;
            accountList.Location = new Point(this.Left + 100, this.Top + 100);
            accountList.ShowDialog();
            this.setButtons();
        }

        private void AcntList_FormClosed(object sender, FormClosedEventArgs e)
        {

            ExitBtn.PerformClick();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            encrypt.EncryptAndSerialize(SingletonList.Instance.PassText, SingletonList.Instance.GetList); 
            this.Close();
            System.Environment.Exit(0);
            
        }

        private void setButtons()
        {
            if (SingletonList.Instance.GetList.Count == 0)
            {
                EditBtn.Enabled = false;
                RemoveBtn.Enabled = false;
                listBox1.Enabled = false;
            }
            else
            {
                EditBtn.Enabled = true;
                RemoveBtn.Enabled = true;
                listBox1.Enabled = true;
            }
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword chngPass = new ChangePassword();
            chngPass.ShowDialog();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuHelp menuHelp = new MenuHelp();
            menuHelp.StartPosition = FormStartPosition.Manual;
            menuHelp.Location = new Point(this.Left + 100, this.Top + 100);
            menuHelp.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitBtn.PerformClick();
        }
    }
}
