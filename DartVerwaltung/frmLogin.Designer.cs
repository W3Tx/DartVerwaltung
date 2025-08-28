namespace DartVerwaltung
{
    partial class frmLogin
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
            btnLoginButton = new Button();
            lblLoginBenutzername = new Label();
            txtLoginBenutzername = new TextBox();
            lblLoginPasswort = new Label();
            label3 = new Label();
            mtxtLoginPasswort = new MaskedTextBox();
            mtxtLoginPasswortConfirm = new MaskedTextBox();
            btnLoginRegistry = new Button();
            SuspendLayout();
            // 
            // btnLoginButton
            // 
            btnLoginButton.Location = new Point(149, 350);
            btnLoginButton.Name = "btnLoginButton";
            btnLoginButton.Size = new Size(150, 23);
            btnLoginButton.TabIndex = 0;
            btnLoginButton.Text = "Login";
            btnLoginButton.UseVisualStyleBackColor = true;
            btnLoginButton.Click += btnLoginButton_Click;
            // 
            // lblLoginBenutzername
            // 
            lblLoginBenutzername.Location = new Point(149, 167);
            lblLoginBenutzername.Name = "lblLoginBenutzername";
            lblLoginBenutzername.Size = new Size(150, 19);
            lblLoginBenutzername.TabIndex = 1;
            lblLoginBenutzername.Text = "Benutzername";
            lblLoginBenutzername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLoginBenutzername
            // 
            txtLoginBenutzername.Location = new Point(149, 189);
            txtLoginBenutzername.Name = "txtLoginBenutzername";
            txtLoginBenutzername.Size = new Size(150, 23);
            txtLoginBenutzername.TabIndex = 3;
            // 
            // lblLoginPasswort
            // 
            lblLoginPasswort.Location = new Point(149, 237);
            lblLoginPasswort.Name = "lblLoginPasswort";
            lblLoginPasswort.Size = new Size(150, 19);
            lblLoginPasswort.TabIndex = 5;
            lblLoginPasswort.Text = "Passwort";
            lblLoginPasswort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 51);
            label3.Name = "label3";
            label3.Size = new Size(266, 45);
            label3.TabIndex = 6;
            label3.Text = "Club Managment";
            // 
            // mtxtLoginPasswort
            // 
            mtxtLoginPasswort.Location = new Point(149, 259);
            mtxtLoginPasswort.Name = "mtxtLoginPasswort";
            mtxtLoginPasswort.PasswordChar = '*';
            mtxtLoginPasswort.Size = new Size(150, 23);
            mtxtLoginPasswort.TabIndex = 7;
            // 
            // mtxtLoginPasswortConfirm
            // 
            mtxtLoginPasswortConfirm.Location = new Point(149, 288);
            mtxtLoginPasswortConfirm.Name = "mtxtLoginPasswortConfirm";
            mtxtLoginPasswortConfirm.Size = new Size(150, 23);
            mtxtLoginPasswortConfirm.TabIndex = 8;
            // 
            // btnLoginRegistry
            // 
            btnLoginRegistry.Location = new Point(149, 379);
            btnLoginRegistry.Name = "btnLoginRegistry";
            btnLoginRegistry.Size = new Size(150, 23);
            btnLoginRegistry.TabIndex = 9;
            btnLoginRegistry.Text = "Registrieren";
            btnLoginRegistry.UseVisualStyleBackColor = true;
            btnLoginRegistry.Click += btnLoginRegistry_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 433);
            Controls.Add(btnLoginRegistry);
            Controls.Add(mtxtLoginPasswortConfirm);
            Controls.Add(mtxtLoginPasswort);
            Controls.Add(label3);
            Controls.Add(lblLoginPasswort);
            Controls.Add(txtLoginBenutzername);
            Controls.Add(lblLoginBenutzername);
            Controls.Add(btnLoginButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitglieder Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginButton;
        private Label lblLoginBenutzername;
        private TextBox txtLoginBenutzername;
        private Label lblLoginPasswort;
        private Label label3;
        private MaskedTextBox mtxtLoginPasswort;
        private MaskedTextBox mtxtLoginPasswortConfirm;
        private Button btnLoginRegistry;
    }
}