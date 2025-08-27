namespace DartVerwaltung
{
    partial class frmStartseite
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            btnStartseiteBearbeiten = new Button();
            btnStartseiteLoeschen = new Button();
            dgMemberListe = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vornameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nachnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            familienstandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            geburtstagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eintrittsdatumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            berufDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            informationenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberBindingSource3 = new BindingSource(components);
            memberBindingSource2 = new BindingSource(components);
            dataContextBindingSource = new BindingSource(components);
            memberBindingSource1 = new BindingSource(components);
            memberBindingSource = new BindingSource(components);
            btnStartseiteHinzufuegen = new Button();
            label1 = new Label();
            btnStartseiteAnzeigen = new Button();
            btnStartseiteRefresh = new Button();
            btnStartseiteExpo = new Button();
            memberBindingSource4 = new BindingSource(components);
            label2 = new Label();
            txtStartseiteMitgliederIDVon = new TextBox();
            txtStartseiteMitgliederIDBis = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtStartseiteName = new TextBox();
            txtStartseiteNachname = new TextBox();
            txtStartseiteMitgliederID = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtStartseiteAlterBis = new TextBox();
            txtStartseiteAlterVon = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgMemberListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource4).BeginInit();
            SuspendLayout();
            // 
            // btnStartseiteBearbeiten
            // 
            btnStartseiteBearbeiten.Location = new Point(12, 309);
            btnStartseiteBearbeiten.Name = "btnStartseiteBearbeiten";
            btnStartseiteBearbeiten.Size = new Size(75, 23);
            btnStartseiteBearbeiten.TabIndex = 1;
            btnStartseiteBearbeiten.Text = "Bearbeiten";
            btnStartseiteBearbeiten.UseVisualStyleBackColor = true;
            btnStartseiteBearbeiten.Click += btnStartseiteBearbeiten_Click;
            // 
            // btnStartseiteLoeschen
            // 
            btnStartseiteLoeschen.Location = new Point(147, 309);
            btnStartseiteLoeschen.Name = "btnStartseiteLoeschen";
            btnStartseiteLoeschen.Size = new Size(75, 23);
            btnStartseiteLoeschen.TabIndex = 2;
            btnStartseiteLoeschen.Text = "Löschen";
            btnStartseiteLoeschen.UseVisualStyleBackColor = true;
            btnStartseiteLoeschen.Click += btnStartseiteLoeschen_Click;
            // 
            // dgMemberListe
            // 
            dgMemberListe.AllowUserToAddRows = false;
            dgMemberListe.AutoGenerateColumns = false;
            dgMemberListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgMemberListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMemberListe.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nrDataGridViewTextBoxColumn, titelDataGridViewTextBoxColumn, vornameDataGridViewTextBoxColumn, nachnameDataGridViewTextBoxColumn, familienstandDataGridViewTextBoxColumn, geburtstagDataGridViewTextBoxColumn, eintrittsdatumDataGridViewTextBoxColumn, berufDataGridViewTextBoxColumn, informationenDataGridViewTextBoxColumn });
            dgMemberListe.DataSource = memberBindingSource3;
            dgMemberListe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgMemberListe.Location = new Point(228, 40);
            dgMemberListe.Name = "dgMemberListe";
            dgMemberListe.Size = new Size(760, 379);
            dgMemberListe.TabIndex = 44;
            dgMemberListe.SelectionChanged += dgMemberListe_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // nrDataGridViewTextBoxColumn
            // 
            nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            nrDataGridViewTextBoxColumn.ReadOnly = true;
            nrDataGridViewTextBoxColumn.Width = 45;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            titelDataGridViewTextBoxColumn.Width = 54;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            vornameDataGridViewTextBoxColumn.Width = 79;
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            nachnameDataGridViewTextBoxColumn.Width = 90;
            // 
            // familienstandDataGridViewTextBoxColumn
            // 
            familienstandDataGridViewTextBoxColumn.DataPropertyName = "Familienstand";
            familienstandDataGridViewTextBoxColumn.HeaderText = "Familienstand";
            familienstandDataGridViewTextBoxColumn.Name = "familienstandDataGridViewTextBoxColumn";
            familienstandDataGridViewTextBoxColumn.Width = 106;
            // 
            // geburtstagDataGridViewTextBoxColumn
            // 
            geburtstagDataGridViewTextBoxColumn.DataPropertyName = "Geburtstag";
            geburtstagDataGridViewTextBoxColumn.HeaderText = "Geburtstag";
            geburtstagDataGridViewTextBoxColumn.Name = "geburtstagDataGridViewTextBoxColumn";
            geburtstagDataGridViewTextBoxColumn.Width = 90;
            // 
            // eintrittsdatumDataGridViewTextBoxColumn
            // 
            eintrittsdatumDataGridViewTextBoxColumn.DataPropertyName = "Eintrittsdatum";
            eintrittsdatumDataGridViewTextBoxColumn.HeaderText = "Eintrittsdatum";
            eintrittsdatumDataGridViewTextBoxColumn.Name = "eintrittsdatumDataGridViewTextBoxColumn";
            eintrittsdatumDataGridViewTextBoxColumn.Width = 107;
            // 
            // berufDataGridViewTextBoxColumn
            // 
            berufDataGridViewTextBoxColumn.DataPropertyName = "Beruf";
            berufDataGridViewTextBoxColumn.HeaderText = "Beruf";
            berufDataGridViewTextBoxColumn.Name = "berufDataGridViewTextBoxColumn";
            berufDataGridViewTextBoxColumn.Width = 60;
            // 
            // informationenDataGridViewTextBoxColumn
            // 
            informationenDataGridViewTextBoxColumn.DataPropertyName = "Informationen";
            informationenDataGridViewTextBoxColumn.HeaderText = "Informationen";
            informationenDataGridViewTextBoxColumn.Name = "informationenDataGridViewTextBoxColumn";
            informationenDataGridViewTextBoxColumn.Width = 108;
            // 
            // memberBindingSource3
            // 
            memberBindingSource3.DataSource = typeof(Database.Entities.Member);
            // 
            // memberBindingSource2
            // 
            memberBindingSource2.DataSource = typeof(Database.Entities.Member);
            // 
            // dataContextBindingSource
            // 
            dataContextBindingSource.DataSource = typeof(Database.DataContext);
            // 
            // memberBindingSource1
            // 
            memberBindingSource1.DataSource = typeof(Database.Entities.Member);
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Database.Entities.Member);
            // 
            // btnStartseiteHinzufuegen
            // 
            btnStartseiteHinzufuegen.Location = new Point(12, 338);
            btnStartseiteHinzufuegen.Name = "btnStartseiteHinzufuegen";
            btnStartseiteHinzufuegen.Size = new Size(210, 23);
            btnStartseiteHinzufuegen.TabIndex = 45;
            btnStartseiteHinzufuegen.Text = "Hinzufügen";
            btnStartseiteHinzufuegen.UseVisualStyleBackColor = true;
            btnStartseiteHinzufuegen.Click += btnStartseiteHinzufuegen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 47;
            label1.Text = "Mitgliederliste";
            // 
            // btnStartseiteAnzeigen
            // 
            btnStartseiteAnzeigen.Location = new Point(882, 11);
            btnStartseiteAnzeigen.Name = "btnStartseiteAnzeigen";
            btnStartseiteAnzeigen.Size = new Size(106, 23);
            btnStartseiteAnzeigen.TabIndex = 48;
            btnStartseiteAnzeigen.Text = "Statistik";
            btnStartseiteAnzeigen.UseVisualStyleBackColor = true;
            btnStartseiteAnzeigen.Click += btnStartseiteAnzeigen_Click;
            // 
            // btnStartseiteRefresh
            // 
            btnStartseiteRefresh.Location = new Point(12, 367);
            btnStartseiteRefresh.Name = "btnStartseiteRefresh";
            btnStartseiteRefresh.Size = new Size(210, 23);
            btnStartseiteRefresh.TabIndex = 49;
            btnStartseiteRefresh.Text = "Refresh";
            btnStartseiteRefresh.UseVisualStyleBackColor = true;
            btnStartseiteRefresh.Click += btnStartseiteRefresh_Click;
            // 
            // btnStartseiteExpo
            // 
            btnStartseiteExpo.Location = new Point(12, 396);
            btnStartseiteExpo.Name = "btnStartseiteExpo";
            btnStartseiteExpo.Size = new Size(210, 23);
            btnStartseiteExpo.TabIndex = 51;
            btnStartseiteExpo.Text = "Exportieren";
            btnStartseiteExpo.UseVisualStyleBackColor = true;
            btnStartseiteExpo.Click += btnStartseiteExpo_Click;
            // 
            // memberBindingSource4
            // 
            memberBindingSource4.DataSource = typeof(Database.Entities.Member);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 91);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 55;
            label2.Text = "Mitgl-Nr.";
            // 
            // txtStartseiteMitgliederIDVon
            // 
            txtStartseiteMitgliederIDVon.Location = new Point(106, 88);
            txtStartseiteMitgliederIDVon.Name = "txtStartseiteMitgliederIDVon";
            txtStartseiteMitgliederIDVon.PlaceholderText = "Von";
            txtStartseiteMitgliederIDVon.Size = new Size(46, 23);
            txtStartseiteMitgliederIDVon.TabIndex = 56;
            // 
            // txtStartseiteMitgliederIDBis
            // 
            txtStartseiteMitgliederIDBis.Location = new Point(176, 88);
            txtStartseiteMitgliederIDBis.Name = "txtStartseiteMitgliederIDBis";
            txtStartseiteMitgliederIDBis.PlaceholderText = "Bis";
            txtStartseiteMitgliederIDBis.Size = new Size(46, 23);
            txtStartseiteMitgliederIDBis.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 91);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 58;
            label3.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 149);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 59;
            label4.Text = "Name";
            // 
            // txtStartseiteName
            // 
            txtStartseiteName.Location = new Point(106, 146);
            txtStartseiteName.Name = "txtStartseiteName";
            txtStartseiteName.PlaceholderText = "Vorname";
            txtStartseiteName.Size = new Size(116, 23);
            txtStartseiteName.TabIndex = 60;
            txtStartseiteName.TextChanged += txtStartseiteName_TextChanged;
            // 
            // txtStartseiteNachname
            // 
            txtStartseiteNachname.Location = new Point(106, 175);
            txtStartseiteNachname.Name = "txtStartseiteNachname";
            txtStartseiteNachname.PlaceholderText = "Nachname";
            txtStartseiteNachname.Size = new Size(116, 23);
            txtStartseiteNachname.TabIndex = 62;
            txtStartseiteNachname.TextChanged += txtStartseiteNachname_TextChanged;
            // 
            // txtStartseiteMitgliederID
            // 
            txtStartseiteMitgliederID.Location = new Point(106, 117);
            txtStartseiteMitgliederID.Name = "txtStartseiteMitgliederID";
            txtStartseiteMitgliederID.PlaceholderText = "Vorname";
            txtStartseiteMitgliederID.Size = new Size(116, 23);
            txtStartseiteMitgliederID.TabIndex = 66;
            txtStartseiteMitgliederID.TextChanged += txtStartseiteMitgliederID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 120);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 65;
            label5.Text = "Mitgl-ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 207);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 70;
            label6.Text = "-";
            // 
            // txtStartseiteAlterBis
            // 
            txtStartseiteAlterBis.Location = new Point(176, 204);
            txtStartseiteAlterBis.Name = "txtStartseiteAlterBis";
            txtStartseiteAlterBis.PlaceholderText = "Bis";
            txtStartseiteAlterBis.Size = new Size(46, 23);
            txtStartseiteAlterBis.TabIndex = 69;
            // 
            // txtStartseiteAlterVon
            // 
            txtStartseiteAlterVon.Location = new Point(106, 204);
            txtStartseiteAlterVon.Name = "txtStartseiteAlterVon";
            txtStartseiteAlterVon.PlaceholderText = "Von";
            txtStartseiteAlterVon.Size = new Size(46, 23);
            txtStartseiteAlterVon.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 207);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 67;
            label7.Text = "Alter von";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 40);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 71;
            label8.Text = "Filterung";
            // 
            // frmStartseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 433);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtStartseiteAlterBis);
            Controls.Add(txtStartseiteAlterVon);
            Controls.Add(label7);
            Controls.Add(txtStartseiteMitgliederID);
            Controls.Add(label5);
            Controls.Add(txtStartseiteNachname);
            Controls.Add(txtStartseiteName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStartseiteMitgliederIDBis);
            Controls.Add(txtStartseiteMitgliederIDVon);
            Controls.Add(label2);
            Controls.Add(btnStartseiteExpo);
            Controls.Add(btnStartseiteRefresh);
            Controls.Add(btnStartseiteAnzeigen);
            Controls.Add(label1);
            Controls.Add(btnStartseiteHinzufuegen);
            Controls.Add(dgMemberListe);
            Controls.Add(btnStartseiteLoeschen);
            Controls.Add(btnStartseiteBearbeiten);
            Name = "frmStartseite";
            Text = "Dart Verwaltung";
            Shown += Startseite_Shown;
            ((System.ComponentModel.ISupportInitialize)dgMemberListe).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private Button btnStartseiteBearbeiten;
        private Button btnStartseiteLoeschen;
        private DataGridView dgMemberListe;
        private Button btnStartseiteHinzufuegen;
        private BindingSource memberBindingSource;
        private BindingSource memberBindingSource1;
        private BindingSource dataContextBindingSource;
        private Label label1;
        private Button btnStartseiteAnzeigen;
        private BindingSource memberBindingSource2;
        private BindingSource memberBindingSource3;
        private Button btnStartseiteRefresh;
        private Button btnStartseiteExpo;
        private BindingSource memberBindingSource4;
        private Label label2;
        private TextBox txtStartseiteMitgliederIDVon;
        private TextBox txtStartseiteMitgliederIDBis;
        private Label label3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn familienstandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn geburtstagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eintrittsdatumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn berufDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn informationenDataGridViewTextBoxColumn;
        private Label label4;
        private TextBox txtStartseiteName;
        private TextBox txtStartseiteNachname;
        private TextBox txtStartseiteMitgliederID;
        private Label label5;
        private Label label6;
        private TextBox txtStartseiteAlterBis;
        private TextBox txtStartseiteAlterVon;
        private Label label7;
        private Label label8;
    }
}
