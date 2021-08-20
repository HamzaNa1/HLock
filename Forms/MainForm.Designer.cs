
namespace HLock.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newPasswordBtn = new System.Windows.Forms.Button();
            this.dataLst = new System.Windows.Forms.ListView();
            this.tagColumn = new System.Windows.Forms.ColumnHeader();
            this.passwordColumn = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // newPasswordBtn
            // 
            this.newPasswordBtn.Location = new System.Drawing.Point(13, 13);
            this.newPasswordBtn.Name = "newPasswordBtn";
            this.newPasswordBtn.Size = new System.Drawing.Size(230, 29);
            this.newPasswordBtn.TabIndex = 0;
            this.newPasswordBtn.Text = "Add New Password";
            this.newPasswordBtn.UseVisualStyleBackColor = true;
            this.newPasswordBtn.Click += new System.EventHandler(this.newPasswordBtn_Click);
            // 
            // dataLst
            // 
            this.dataLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tagColumn,
            this.passwordColumn});
            this.dataLst.FullRowSelect = true;
            this.dataLst.GridLines = true;
            this.dataLst.HideSelection = false;
            this.dataLst.Location = new System.Drawing.Point(13, 64);
            this.dataLst.MultiSelect = false;
            this.dataLst.Name = "dataLst";
            this.dataLst.Size = new System.Drawing.Size(657, 457);
            this.dataLst.TabIndex = 1;
            this.dataLst.UseCompatibleStateImageBehavior = false;
            this.dataLst.View = System.Windows.Forms.View.Details;
            this.dataLst.DoubleClick += new System.EventHandler(this.dataLst_DoubleClick);
            this.dataLst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataLst_KeyDown);
            // 
            // tagColumn
            // 
            this.tagColumn.Text = "Tag";
            this.tagColumn.Width = 100;
            // 
            // passwordColumn
            // 
            this.passwordColumn.Text = "Password";
            this.passwordColumn.Width = 550;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 533);
            this.Controls.Add(this.dataLst);
            this.Controls.Add(this.newPasswordBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newPasswordBtn;
        private System.Windows.Forms.ListView dataLst;
        private System.Windows.Forms.ColumnHeader tagColumn;
        private System.Windows.Forms.ColumnHeader passwordColumn;
    }
}