using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
