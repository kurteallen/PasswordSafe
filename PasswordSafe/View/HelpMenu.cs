using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSafe.View
{
    public partial class MenuHelp : Form
    {
        public MenuHelp()
        {
            InitializeComponent();
        }

        private void HelpTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Help_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Resources.Help;
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
          

            System.Console.WriteLine("This is the sender " + sender.GetType().FullName);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
