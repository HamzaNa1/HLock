using System;
using System.Windows.Forms;
using HLock.Password;

namespace HLock.Forms
{
    public partial class LoginForm : Form
    {
        public bool LoginSucceed { get; private set; }

        public LoginForm()
        {
            InitializeComponent();

            LoginSucceed = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                MessageBox.Show("Password can't be empty.");
                return;
            }

            PasswordHandler.Initialize(passwordTxt.Text);

            LoginSucceed = true;
            Close();
        }
    }
}
