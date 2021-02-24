namespace okno
{
    partial class okno
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okno));
            this.label1 = new System.Windows.Forms.Label();
            this.haslo = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj Hasło ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // haslo
            // 
            this.haslo.AcceptsReturn = true;
            this.haslo.BackColor = System.Drawing.SystemColors.Window;
            this.haslo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.haslo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.haslo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo.Location = new System.Drawing.Point(45, 52);
            this.haslo.MaxLength = 16;
            this.haslo.Name = "haslo";
            this.haslo.PasswordChar = '*';
            this.haslo.Size = new System.Drawing.Size(231, 24);
            this.haslo.TabIndex = 1;
            this.haslo.UseSystemPasswordChar = true;
            this.haslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(273, 53);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(55, 26);
            this.Login.TabIndex = 2;
            this.Login.Text = "LogIn";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(329, 97);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haslo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "okno";
            this.Text = "Szyfrator 9000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.Button Login;
    }
}

