namespace DartVerwaltung
{
    partial class frmUserVerwaltung
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pcMember = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtMemberVorname = new TextBox();
            txtMemberNachname = new TextBox();
            txtMemberTitel = new TextBox();
            txtMemberStand = new TextBox();
            txtMemberBeruf = new TextBox();
            txtMemberNummer = new TextBox();
            txtMemberInfo = new RichTextBox();
            label11 = new Label();
            btnMemberBLaden = new Button();
            btnMemberBLoeschen = new Button();
            btnMemberCancel = new Button();
            btnMemberSpeichern = new Button();
            dtpGeburtstag = new DateTimePicker();
            dtpEintritt = new DateTimePicker();
            dtpAustritt = new DateTimePicker();
            label7 = new Label();
            txtMemberAlter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcMember).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 138);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 22;
            label5.Text = "Familienstand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 138);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 21;
            label4.Text = "Titel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 109);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 20;
            label3.Text = "Nachname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 109);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 19;
            label2.Text = "Vorname";
            // 
            // pcMember
            // 
            pcMember.BackColor = SystemColors.ActiveBorder;
            pcMember.Location = new Point(77, 64);
            pcMember.Name = "pcMember";
            pcMember.Size = new Size(150, 181);
            pcMember.SizeMode = PictureBoxSizeMode.CenterImage;
            pcMember.TabIndex = 13;
            pcMember.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 64);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 12;
            label1.Text = "Mietgliedsnummer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 167);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 23;
            label6.Text = "Geburtstag";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(250, 196);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 25;
            label8.Text = "Eintrittsdatum";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(490, 196);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 26;
            label9.Text = "Austrittsdatum";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(250, 225);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 27;
            label10.Text = "Beruf";
            // 
            // txtMemberVorname
            // 
            txtMemberVorname.BorderStyle = BorderStyle.FixedSingle;
            txtMemberVorname.Location = new Point(338, 106);
            txtMemberVorname.Name = "txtMemberVorname";
            txtMemberVorname.Size = new Size(100, 23);
            txtMemberVorname.TabIndex = 28;
            // 
            // txtMemberNachname
            // 
            txtMemberNachname.BorderStyle = BorderStyle.FixedSingle;
            txtMemberNachname.Location = new Point(582, 106);
            txtMemberNachname.Name = "txtMemberNachname";
            txtMemberNachname.Size = new Size(100, 23);
            txtMemberNachname.TabIndex = 29;
            // 
            // txtMemberTitel
            // 
            txtMemberTitel.BorderStyle = BorderStyle.FixedSingle;
            txtMemberTitel.Location = new Point(338, 135);
            txtMemberTitel.Name = "txtMemberTitel";
            txtMemberTitel.Size = new Size(100, 23);
            txtMemberTitel.TabIndex = 30;
            // 
            // txtMemberStand
            // 
            txtMemberStand.BorderStyle = BorderStyle.FixedSingle;
            txtMemberStand.Location = new Point(582, 135);
            txtMemberStand.Name = "txtMemberStand";
            txtMemberStand.Size = new Size(100, 23);
            txtMemberStand.TabIndex = 31;
            // 
            // txtMemberBeruf
            // 
            txtMemberBeruf.BorderStyle = BorderStyle.FixedSingle;
            txtMemberBeruf.Location = new Point(338, 222);
            txtMemberBeruf.Name = "txtMemberBeruf";
            txtMemberBeruf.Size = new Size(344, 23);
            txtMemberBeruf.TabIndex = 36;
            // 
            // txtMemberNummer
            // 
            txtMemberNummer.BorderStyle = BorderStyle.FixedSingle;
            txtMemberNummer.Location = new Point(364, 61);
            txtMemberNummer.Name = "txtMemberNummer";
            txtMemberNummer.Size = new Size(318, 23);
            txtMemberNummer.TabIndex = 37;
            // 
            // txtMemberInfo
            // 
            txtMemberInfo.BorderStyle = BorderStyle.FixedSingle;
            txtMemberInfo.Location = new Point(250, 294);
            txtMemberInfo.Name = "txtMemberInfo";
            txtMemberInfo.Size = new Size(432, 94);
            txtMemberInfo.TabIndex = 38;
            txtMemberInfo.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(250, 276);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 39;
            label11.Text = "Informationen";
            // 
            // btnMemberBLaden
            // 
            btnMemberBLaden.Location = new Point(77, 251);
            btnMemberBLaden.Name = "btnMemberBLaden";
            btnMemberBLaden.Size = new Size(60, 25);
            btnMemberBLaden.TabIndex = 40;
            btnMemberBLaden.Text = "Laden";
            btnMemberBLaden.UseVisualStyleBackColor = true;
            btnMemberBLaden.Click += btnMemberBLaden_Click;
            // 
            // btnMemberBLoeschen
            // 
            btnMemberBLoeschen.Location = new Point(167, 251);
            btnMemberBLoeschen.Name = "btnMemberBLoeschen";
            btnMemberBLoeschen.Size = new Size(60, 25);
            btnMemberBLoeschen.TabIndex = 41;
            btnMemberBLoeschen.Text = "Löschen";
            btnMemberBLoeschen.UseVisualStyleBackColor = true;
            btnMemberBLoeschen.Click += btnMemberBLoeschen_Click;
            // 
            // btnMemberCancel
            // 
            btnMemberCancel.Location = new Point(713, 415);
            btnMemberCancel.Name = "btnMemberCancel";
            btnMemberCancel.Size = new Size(75, 23);
            btnMemberCancel.TabIndex = 42;
            btnMemberCancel.Text = "Schließen";
            btnMemberCancel.UseVisualStyleBackColor = true;
            btnMemberCancel.Click += btnMemberCancel_Click;
            // 
            // btnMemberSpeichern
            // 
            btnMemberSpeichern.Location = new Point(632, 415);
            btnMemberSpeichern.Name = "btnMemberSpeichern";
            btnMemberSpeichern.Size = new Size(75, 23);
            btnMemberSpeichern.TabIndex = 43;
            btnMemberSpeichern.Text = "Speichern";
            btnMemberSpeichern.UseVisualStyleBackColor = true;
            btnMemberSpeichern.Click += btnMemberSpeichern_Click;
            // 
            // dtpGeburtstag
            // 
            dtpGeburtstag.Format = DateTimePickerFormat.Short;
            dtpGeburtstag.Location = new Point(338, 164);
            dtpGeburtstag.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpGeburtstag.Name = "dtpGeburtstag";
            dtpGeburtstag.Size = new Size(100, 23);
            dtpGeburtstag.TabIndex = 44;
            // 
            // dtpEintritt
            // 
            dtpEintritt.Format = DateTimePickerFormat.Short;
            dtpEintritt.Location = new Point(338, 193);
            dtpEintritt.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpEintritt.Name = "dtpEintritt";
            dtpEintritt.Size = new Size(100, 23);
            dtpEintritt.TabIndex = 45;
            // 
            // dtpAustritt
            // 
            dtpAustritt.Format = DateTimePickerFormat.Short;
            dtpAustritt.Location = new Point(582, 193);
            dtpAustritt.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpAustritt.Name = "dtpAustritt";
            dtpAustritt.Size = new Size(100, 23);
            dtpAustritt.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(490, 167);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 24;
            label7.Text = "Alter";
            // 
            // txtMemberAlter
            // 
            txtMemberAlter.BorderStyle = BorderStyle.FixedSingle;
            txtMemberAlter.Location = new Point(582, 164);
            txtMemberAlter.Name = "txtMemberAlter";
            txtMemberAlter.Size = new Size(100, 23);
            txtMemberAlter.TabIndex = 33;
            // 
            // frmUserVerwaltung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMemberInfo);
            Controls.Add(dtpAustritt);
            Controls.Add(dtpEintritt);
            Controls.Add(dtpGeburtstag);
            Controls.Add(btnMemberSpeichern);
            Controls.Add(btnMemberCancel);
            Controls.Add(btnMemberBLoeschen);
            Controls.Add(btnMemberBLaden);
            Controls.Add(label11);
            Controls.Add(txtMemberNummer);
            Controls.Add(txtMemberBeruf);
            Controls.Add(txtMemberAlter);
            Controls.Add(txtMemberStand);
            Controls.Add(txtMemberTitel);
            Controls.Add(txtMemberNachname);
            Controls.Add(txtMemberVorname);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pcMember);
            Controls.Add(label1);
            Name = "frmUserVerwaltung";
            Text = "UserVerwaltung";
            ((System.ComponentModel.ISupportInitialize)pcMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pcMember;
        private Label label1;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtMemberVorname;
        private TextBox txtMemberNachname;
        private TextBox txtMemberTitel;
        private TextBox txtMemberStand;
        private TextBox txtMemberBeruf;
        private TextBox txtMemberNummer;
        private RichTextBox txtMemberInfo;
        private Label label11;
        private Button btnMemberBLaden;
        private Button btnMemberBLoeschen;
        private Button btnMemberCancel;
        private Button btnMemberSpeichern;
        private DateTimePicker dtpGeburtstag;
        private DateTimePicker dtpEintritt;
        private DateTimePicker dtpAustritt;
        private Label label7;
        private TextBox txtMemberAlter;
    }
}