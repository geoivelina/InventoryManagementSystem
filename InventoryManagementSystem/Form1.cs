using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LoginShowPasswordCheckBox.Checked == true)
            {
                LoginPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                LoginPasswordTextBox.PasswordChar =  '*';
            }
        }

        private void ClearLable_Click(object sender, EventArgs e)
        {
            LoginUserNameTextBox.Text = "";
            LoginPasswordTextBox.Text = "";
        }
    }
}
