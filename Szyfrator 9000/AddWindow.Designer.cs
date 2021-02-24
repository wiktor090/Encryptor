namespace Szyfrator_9000
{
    partial class AddWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWindow));
            this.AddButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.haslolabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.ShowPWD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(5, 394);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(529, 44);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Password";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameTextBox.Location = new System.Drawing.Point(71, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(401, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name.Location = new System.Drawing.Point(68, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 20);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(69, 76);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(53, 20);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginTextBox.Location = new System.Drawing.Point(72, 103);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(401, 23);
            this.LoginTextBox.TabIndex = 3;
            // 
            // haslolabel
            // 
            this.haslolabel.AutoSize = true;
            this.haslolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslolabel.Location = new System.Drawing.Point(69, 214);
            this.haslolabel.Name = "haslolabel";
            this.haslolabel.Size = new System.Drawing.Size(86, 20);
            this.haslolabel.TabIndex = 6;
            this.haslolabel.Text = "Password";
            this.haslolabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmailTextBox.Location = new System.Drawing.Point(73, 172);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(401, 23);
            this.EmailTextBox.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.Location = new System.Drawing.Point(69, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(59, 20);
            this.Email.TabIndex = 8;
            this.Email.Text = "E-Mail";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordTextBox.Location = new System.Drawing.Point(71, 237);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(401, 23);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Notes.Location = new System.Drawing.Point(71, 304);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(56, 20);
            this.Notes.TabIndex = 10;
            this.Notes.Text = "Notes";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NotesTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NotesTextBox.Location = new System.Drawing.Point(73, 327);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(401, 61);
            this.NotesTextBox.TabIndex = 9;
            // 
            // ShowPWD
            // 
            this.ShowPWD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ShowPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPWD.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPWD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowPWD.Location = new System.Drawing.Point(71, 266);
            this.ShowPWD.Name = "ShowPWD";
            this.ShowPWD.Size = new System.Drawing.Size(403, 25);
            this.ShowPWD.TabIndex = 11;
            this.ShowPWD.Text = "Show Password";
            this.ShowPWD.UseVisualStyleBackColor = true;
            this.ShowPWD.Click += new System.EventHandler(this.ShowPWD_Click);
            this.ShowPWD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPWD_MouseDown);
            this.ShowPWD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPWD_MouseUp);
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.ShowPWD);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.haslolabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Load += new System.EventHandler(this.AddWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label haslolabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Button ShowPWD;
    }
}