
namespace Szyfrator_9000
{
    partial class newPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Progressbar = new System.Windows.Forms.ProgressBar();
            this.NoweHasloTextBox = new System.Windows.Forms.TextBox();
            this.PowtozNoweHasloTextBox = new System.Windows.Forms.TextBox();
            this.ShowPWD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SetPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat New Password";
            // 
            // Progressbar
            // 
            this.Progressbar.ForeColor = System.Drawing.Color.Cyan;
            this.Progressbar.Location = new System.Drawing.Point(16, 204);
            this.Progressbar.MarqueeAnimationSpeed = 250;
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(302, 19);
            this.Progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progressbar.TabIndex = 3;
            // 
            // NoweHasloTextBox
            // 
            this.NoweHasloTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NoweHasloTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NoweHasloTextBox.Location = new System.Drawing.Point(16, 87);
            this.NoweHasloTextBox.Name = "NoweHasloTextBox";
            this.NoweHasloTextBox.Size = new System.Drawing.Size(302, 20);
            this.NoweHasloTextBox.TabIndex = 4;
            this.NoweHasloTextBox.UseSystemPasswordChar = true;
            this.NoweHasloTextBox.TextChanged += new System.EventHandler(this.NoweHasloTextBox_TextChanged);
            // 
            // PowtozNoweHasloTextBox
            // 
            this.PowtozNoweHasloTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PowtozNoweHasloTextBox.Location = new System.Drawing.Point(16, 150);
            this.PowtozNoweHasloTextBox.Name = "PowtozNoweHasloTextBox";
            this.PowtozNoweHasloTextBox.Size = new System.Drawing.Size(302, 20);
            this.PowtozNoweHasloTextBox.TabIndex = 5;
            this.PowtozNoweHasloTextBox.UseSystemPasswordChar = true;
            // 
            // ShowPWD
            // 
            this.ShowPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPWD.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowPWD.Location = new System.Drawing.Point(12, 243);
            this.ShowPWD.Name = "ShowPWD";
            this.ShowPWD.Size = new System.Drawing.Size(302, 36);
            this.ShowPWD.TabIndex = 6;
            this.ShowPWD.Text = "See Passwords";
            this.ShowPWD.UseVisualStyleBackColor = false;
            this.ShowPWD.Click += new System.EventHandler(this.ShowPWD_Click);
            this.ShowPWD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPWD_MouseDown);
            this.ShowPWD.MouseLeave += new System.EventHandler(this.ShowPWD_MouseLeave);
            this.ShowPWD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPWD_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password Lenght";
            // 
            // SetPwd
            // 
            this.SetPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetPwd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetPwd.Location = new System.Drawing.Point(12, 285);
            this.SetPwd.Name = "SetPwd";
            this.SetPwd.Size = new System.Drawing.Size(302, 35);
            this.SetPwd.TabIndex = 8;
            this.SetPwd.Text = "Set New Password";
            this.SetPwd.UseVisualStyleBackColor = false;
            this.SetPwd.Click += new System.EventHandler(this.SetPwd_Click);
            // 
            // newPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(325, 326);
            this.Controls.Add(this.SetPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowPWD);
            this.Controls.Add(this.PowtozNoweHasloTextBox);
            this.Controls.Add(this.NoweHasloTextBox);
            this.Controls.Add(this.Progressbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newPassword";
            this.Text = "NewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar Progressbar;
        private System.Windows.Forms.TextBox NoweHasloTextBox;
        private System.Windows.Forms.TextBox PowtozNoweHasloTextBox;
        private System.Windows.Forms.Button ShowPWD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SetPwd;
    }
}