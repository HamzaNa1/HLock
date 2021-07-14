
namespace HLock
{
    partial class GeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uppercaseChk = new System.Windows.Forms.CheckBox();
            this.numbersChk = new System.Windows.Forms.CheckBox();
            this.specialCharactersChk = new System.Windows.Forms.CheckBox();
            this.amountValue = new System.Windows.Forms.NumericUpDown();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.addPasswordBtn = new System.Windows.Forms.Button();
            this.tagTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // uppercaseChk
            // 
            this.uppercaseChk.AutoSize = true;
            this.uppercaseChk.Location = new System.Drawing.Point(13, 13);
            this.uppercaseChk.Name = "uppercaseChk";
            this.uppercaseChk.Size = new System.Drawing.Size(101, 24);
            this.uppercaseChk.TabIndex = 0;
            this.uppercaseChk.Text = "Uppercase";
            this.uppercaseChk.UseVisualStyleBackColor = true;
            // 
            // numbersChk
            // 
            this.numbersChk.AutoSize = true;
            this.numbersChk.Location = new System.Drawing.Point(242, 13);
            this.numbersChk.Name = "numbersChk";
            this.numbersChk.Size = new System.Drawing.Size(91, 24);
            this.numbersChk.TabIndex = 1;
            this.numbersChk.Text = "Numbers";
            this.numbersChk.UseVisualStyleBackColor = true;
            // 
            // specialCharactersChk
            // 
            this.specialCharactersChk.AutoSize = true;
            this.specialCharactersChk.Location = new System.Drawing.Point(13, 43);
            this.specialCharactersChk.Name = "specialCharactersChk";
            this.specialCharactersChk.Size = new System.Drawing.Size(152, 24);
            this.specialCharactersChk.TabIndex = 2;
            this.specialCharactersChk.Text = "Special Characters";
            this.specialCharactersChk.UseVisualStyleBackColor = true;
            // 
            // amountValue
            // 
            this.amountValue.Location = new System.Drawing.Point(242, 42);
            this.amountValue.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.amountValue.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.amountValue.Name = "amountValue";
            this.amountValue.Size = new System.Drawing.Size(55, 27);
            this.amountValue.TabIndex = 3;
            this.amountValue.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(12, 73);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(79, 29);
            this.GenerateBtn.TabIndex = 4;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(12, 108);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.ReadOnly = true;
            this.passwordTxt.Size = new System.Drawing.Size(320, 27);
            this.passwordTxt.TabIndex = 5;
            // 
            // addPasswordBtn
            // 
            this.addPasswordBtn.Location = new System.Drawing.Point(13, 184);
            this.addPasswordBtn.Name = "addPasswordBtn";
            this.addPasswordBtn.Size = new System.Drawing.Size(320, 29);
            this.addPasswordBtn.TabIndex = 6;
            this.addPasswordBtn.Text = "Add New Password";
            this.addPasswordBtn.UseVisualStyleBackColor = true;
            this.addPasswordBtn.Click += new System.EventHandler(this.addPasswordBtn_Click);
            // 
            // tagTxt
            // 
            this.tagTxt.Location = new System.Drawing.Point(116, 145);
            this.tagTxt.Name = "tagTxt";
            this.tagTxt.Size = new System.Drawing.Size(217, 27);
            this.tagTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password Tag:";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tagTxt);
            this.Controls.Add(this.addPasswordBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.amountValue);
            this.Controls.Add(this.specialCharactersChk);
            this.Controls.Add(this.numbersChk);
            this.Controls.Add(this.uppercaseChk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratorForm";
            this.Text = "Generator";
            ((System.ComponentModel.ISupportInitialize)(this.amountValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uppercaseChk;
        private System.Windows.Forms.CheckBox numbersChk;
        private System.Windows.Forms.CheckBox specialCharactersChk;
        private System.Windows.Forms.NumericUpDown amountValue;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button addPasswordBtn;
        private System.Windows.Forms.TextBox tagTxt;
        private System.Windows.Forms.Label label1;
    }
}

