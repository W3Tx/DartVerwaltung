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
            profilbildDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vornameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nachnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            familienstandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            geburtstagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eintrittsdatumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            austrittsdatumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgMemberListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnStartseiteBearbeiten
            // 
            btnStartseiteBearbeiten.Location = new Point(160, 426);
            btnStartseiteBearbeiten.Name = "btnStartseiteBearbeiten";
            btnStartseiteBearbeiten.Size = new Size(75, 23);
            btnStartseiteBearbeiten.TabIndex = 1;
            btnStartseiteBearbeiten.Text = "Bearbeiten";
            btnStartseiteBearbeiten.UseVisualStyleBackColor = true;
            btnStartseiteBearbeiten.Click += btnStartseiteBearbeiten_Click;
            // 
            // btnStartseiteLoeschen
            // 
            btnStartseiteLoeschen.Location = new Point(241, 426);
            btnStartseiteLoeschen.Name = "btnStartseiteLoeschen";
            btnStartseiteLoeschen.Size = new Size(75, 23);
            btnStartseiteLoeschen.TabIndex = 2;
            btnStartseiteLoeschen.Text = "Löschen";
            btnStartseiteLoeschen.UseVisualStyleBackColor = true;
            btnStartseiteLoeschen.Click += btnStartseiteLoeschen_Click;
            // 
            // dgMemberListe
            // 
            dgMemberListe.AutoGenerateColumns = false;
            dgMemberListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgMemberListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMemberListe.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nrDataGridViewTextBoxColumn, profilbildDataGridViewTextBoxColumn, titelDataGridViewTextBoxColumn, vornameDataGridViewTextBoxColumn, nachnameDataGridViewTextBoxColumn, familienstandDataGridViewTextBoxColumn, geburtstagDataGridViewTextBoxColumn, eintrittsdatumDataGridViewTextBoxColumn, austrittsdatumDataGridViewTextBoxColumn, berufDataGridViewTextBoxColumn, informationenDataGridViewTextBoxColumn });
            dgMemberListe.DataSource = memberBindingSource3;
            dgMemberListe.Location = new Point(12, 41);
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
            // profilbildDataGridViewTextBoxColumn
            // 
            profilbildDataGridViewTextBoxColumn.DataPropertyName = "Profilbild";
            profilbildDataGridViewTextBoxColumn.HeaderText = "Profilbild";
            profilbildDataGridViewTextBoxColumn.Name = "profilbildDataGridViewTextBoxColumn";
            profilbildDataGridViewTextBoxColumn.ReadOnly = true;
            profilbildDataGridViewTextBoxColumn.Width = 80;
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
            // austrittsdatumDataGridViewTextBoxColumn
            // 
            austrittsdatumDataGridViewTextBoxColumn.DataPropertyName = "Austrittsdatum";
            austrittsdatumDataGridViewTextBoxColumn.HeaderText = "Austrittsdatum";
            austrittsdatumDataGridViewTextBoxColumn.Name = "austrittsdatumDataGridViewTextBoxColumn";
            austrittsdatumDataGridViewTextBoxColumn.Width = 111;
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
            btnStartseiteHinzufuegen.Location = new Point(12, 426);
            btnStartseiteHinzufuegen.Name = "btnStartseiteHinzufuegen";
            btnStartseiteHinzufuegen.Size = new Size(142, 23);
            btnStartseiteHinzufuegen.TabIndex = 45;
            btnStartseiteHinzufuegen.Text = "Hinzufügen";
            btnStartseiteHinzufuegen.UseVisualStyleBackColor = true;
            btnStartseiteHinzufuegen.Click += btnStartseiteHinzufuegen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 47;
            label1.Text = "Mitgliederliste";
            // 
            // btnStartseiteAnzeigen
            // 
            btnStartseiteAnzeigen.Location = new Point(697, 426);
            btnStartseiteAnzeigen.Name = "btnStartseiteAnzeigen";
            btnStartseiteAnzeigen.Size = new Size(75, 23);
            btnStartseiteAnzeigen.TabIndex = 48;
            btnStartseiteAnzeigen.Text = "Statistik";
            btnStartseiteAnzeigen.UseVisualStyleBackColor = true;
            btnStartseiteAnzeigen.Click += btnStartseiteAnzeigen_Click;
            // 
            // frmStartseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profilbildDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn familienstandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn geburtstagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eintrittsdatumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn austrittsdatumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn berufDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn informationenDataGridViewTextBoxColumn;
        private BindingSource memberBindingSource2;
        private BindingSource memberBindingSource3;
    }
}
