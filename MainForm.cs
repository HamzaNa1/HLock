using System;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace HLock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadData();
        }

        private GeneratorForm generatorForm;

        private void newPasswordBtn_Click(object sender, EventArgs e)
        {
            if (generatorForm != null && !generatorForm.IsDisposed)
                return;

            generatorForm = new GeneratorForm();
            generatorForm.Show();
            generatorForm.FormClosed += (_, _) => LoadData();
        }

        private void LoadData()
        {
            dataLst.Items.Clear();

            foreach(string tag in PasswordHandler.Passwords.Keys)
            {
                var password = PasswordHandler.Passwords[tag];

                var tagItem = new ListViewItem(tag);
                var passwordItem = new ListViewSubItem(tagItem, new string('*', password.Length));
                passwordItem.Tag = password;

                dataLst.Items.Add(tagItem).SubItems.Add(passwordItem);
            }
        }

        private void dataLst_DoubleClick(object sender, EventArgs e)
        {
            if (dataLst.SelectedItems.Count < 0)
                return;

            var clicked = dataLst.SelectedItems[0];

            if(clicked != null)
            {
                var tag = clicked.Text;

                var result = MessageBox.Show($"Are you sure you want to remove {tag}.", "Warning", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    PasswordHandler.RemovePassword(tag);
                    LoadData();
                }
            }
        }

        private void dataLst_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                if (dataLst.SelectedItems.Count < 0)
                    return;

                var clicked = dataLst.SelectedItems[0];

                if (clicked != null)
                {
                    var tag = clicked.Text;

                    Clipboard.SetText(PasswordHandler.Passwords[tag]);
                }
            }
        }
    }
}
