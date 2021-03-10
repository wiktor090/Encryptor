namespace Szyfrator_9000
{
    partial class Szyfrator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Szyfrator));
            this.zaszyfruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zapisz = new System.Windows.Forms.Button();
            this.passwordsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwausługi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiddenPWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodaj = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zaszyfruj
            // 
            this.zaszyfruj.BackColor = System.Drawing.SystemColors.GrayText;
            this.zaszyfruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaszyfruj.Location = new System.Drawing.Point(586, 349);
            this.zaszyfruj.Name = "zaszyfruj";
            this.zaszyfruj.Size = new System.Drawing.Size(92, 40);
            this.zaszyfruj.TabIndex = 1;
            this.zaszyfruj.Text = "Open";
            this.zaszyfruj.UseVisualStyleBackColor = false;
            this.zaszyfruj.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encryptor By Wiktor090";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zapisz
            // 
            this.zapisz.BackColor = System.Drawing.SystemColors.GrayText;
            this.zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapisz.Location = new System.Drawing.Point(30, 349);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(92, 40);
            this.zapisz.TabIndex = 3;
            this.zapisz.Text = "Save";
            this.zapisz.UseVisualStyleBackColor = false;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // passwordsDataGridView
            // 
            this.passwordsDataGridView.AllowUserToAddRows = false;
            this.passwordsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passwordsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.passwordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nazwausługi,
            this.Login,
            this.Email,
            this.Password,
            this.HiddenPWD,
            this.Notes});
            this.passwordsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.passwordsDataGridView.Location = new System.Drawing.Point(12, 113);
            this.passwordsDataGridView.Name = "passwordsDataGridView";
            this.passwordsDataGridView.RowHeadersVisible = false;
            this.passwordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passwordsDataGridView.Size = new System.Drawing.Size(690, 171);
            this.passwordsDataGridView.TabIndex = 6;
            this.passwordsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordsDataGridView_CellClick);
            this.passwordsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordsDataGridView_CellContentClick);
            this.passwordsDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordsDataGridView_CellMouseLeave);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nazwausługi
            // 
            this.Nazwausługi.HeaderText = "Name";
            this.Nazwausługi.Name = "Nazwausługi";
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // HiddenPWD
            // 
            this.HiddenPWD.HeaderText = "HiddenPWD";
            this.HiddenPWD.Name = "HiddenPWD";
            this.HiddenPWD.Visible = false;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.SystemColors.GrayText;
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj.Location = new System.Drawing.Point(30, 290);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(92, 40);
            this.Dodaj.TabIndex = 7;
            this.Dodaj.Text = "Add";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Location = new System.Drawing.Point(586, 290);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(92, 40);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete ";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Szyfrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(714, 401);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.passwordsDataGridView);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zaszyfruj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Szyfrator";
            this.Text = "Encryptor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Szyfrator_FormClosed);
            this.Load += new System.EventHandler(this.Szyfrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button zaszyfruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.DataGridView passwordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwausługi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenPWD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button DeleteButton;
    }
}

