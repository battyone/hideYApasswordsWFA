﻿namespace hideYaPasswordWFA
{
    partial class SavePassword
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
            this.EnterEmailtxt = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.EnterPasswordtxt = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.SavePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterEmailtxt
            // 
            this.EnterEmailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterEmailtxt.CausesValidation = false;
            this.EnterEmailtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnterEmailtxt.Enabled = false;
            this.EnterEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterEmailtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterEmailtxt.Location = new System.Drawing.Point(35, 93);
            this.EnterEmailtxt.Multiline = true;
            this.EnterEmailtxt.Name = "EnterEmailtxt";
            this.EnterEmailtxt.ReadOnly = true;
            this.EnterEmailtxt.Size = new System.Drawing.Size(119, 16);
            this.EnterEmailtxt.TabIndex = 3;
            this.EnterEmailtxt.TabStop = false;
            this.EnterEmailtxt.Text = "Enter Email Adress";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(190, 89);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(203, 20);
            this.emailTextbox.TabIndex = 4;
            // 
            // EnterPasswordtxt
            // 
            this.EnterPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterPasswordtxt.CausesValidation = false;
            this.EnterPasswordtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnterPasswordtxt.Enabled = false;
            this.EnterPasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPasswordtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterPasswordtxt.Location = new System.Drawing.Point(35, 171);
            this.EnterPasswordtxt.Multiline = true;
            this.EnterPasswordtxt.Name = "EnterPasswordtxt";
            this.EnterPasswordtxt.ReadOnly = true;
            this.EnterPasswordtxt.Size = new System.Drawing.Size(119, 16);
            this.EnterPasswordtxt.TabIndex = 5;
            this.EnterPasswordtxt.TabStop = false;
            this.EnterPasswordtxt.Text = "Enter Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(190, 167);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(203, 20);
            this.passwordTextbox.TabIndex = 6;
            // 
            // SavePasswordButton
            // 
            this.SavePasswordButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SavePasswordButton.ForeColor = System.Drawing.Color.Black;
            this.SavePasswordButton.Location = new System.Drawing.Point(343, 220);
            this.SavePasswordButton.Name = "SavePasswordButton";
            this.SavePasswordButton.Size = new System.Drawing.Size(79, 28);
            this.SavePasswordButton.TabIndex = 7;
            this.SavePasswordButton.Text = "Save";
            this.SavePasswordButton.UseVisualStyleBackColor = false;
            this.SavePasswordButton.Click += new System.EventHandler(this.SavePasswordButton_Click);
            // 
            // SavePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.SavePasswordButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.EnterPasswordtxt);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.EnterEmailtxt);
            this.MaximizeBox = false;
            this.Name = "SavePassword";
            this.Text = "Save_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterEmailtxt;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox EnterPasswordtxt;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button SavePasswordButton;
    }
}