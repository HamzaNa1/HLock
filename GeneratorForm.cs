using System;
using System.Windows.Forms;

namespace HLock
{
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            var password = PasswordGenerator.Generate((int)amountValue.Value, uppercaseChk.Checked, numbersChk.Checked, specialCharactersChk.Checked);

            passwordTxt.Text = password;
        }

        private void addPasswordBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTxt.Text)) {
                MessageBox.Show("Password is not valid.");
                return;
                    }
            else if (string.IsNullOrWhiteSpace(tagTxt.Text))
            {
                MessageBox.Show("Tag is not valid.");
                return;
            }

            PasswordHandler.AddPassword(tagTxt.Text, passwordTxt.Text);

            this.Close();
        }
    }
}
