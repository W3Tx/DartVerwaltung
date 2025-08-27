using DartVerwaltung.Database;
using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace DartVerwaltung
{
    public partial class frmStartseite : Form
    {
        // EF Core Datenbank verwaltet die Operationen
        private DataContext _dataContext = new DataContext();
        private BindingSource _memberBindingSource = new BindingSource();

        public frmStartseite()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dataContext.Members.Load();
            _memberBindingSource.DataSource = _dataContext.Members.Local.ToBindingList();
            dgMemberListe.DataSource = _memberBindingSource;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _dataContext?.Dispose();
        }

        private void Startseite_Shown(object sender, EventArgs e)
        {
            // Code Beispiel um Daten zu laden
            // Erstellt eine Liste aller Mitglieder in der Datenbank
            // List<Member> memberList = _dataContext.Members.ToList();
        }

        private void btnStartseiteHinzufuegen_Click(object sender, EventArgs e)
        {
            frmUserVerwaltung frmUserVerwaltung = new frmUserVerwaltung();

            // Member Objekt wird erstellt und an das Formular übergeben
            Member newMember = new Member();

            EditMember(newMember);
        }

        private void btnStartseiteAnzeigen_Click(object sender, EventArgs e)
        {
            // Öffnet das Formular zur Statistik
            frmClubStatistik frmClubStatistiken = new frmClubStatistik(_dataContext);
            frmClubStatistiken.ShowDialog();
        }

        private void btnStartseiteBearbeiten_Click(object sender, EventArgs e)
        {
            var test = dgMemberListe.CurrentRow.DataBoundItem;
            if (test is Member selectedMember)
            {
                EditMember(selectedMember);
            }
        }

        // TEST!!!
        // Aktiviert oder deaktiviert den Bearbeiten-Button basierend auf der Auswahl im DataGridView
        private void dgMemberListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMemberListe.CurrentRow == null)
            {
                btnStartseiteBearbeiten.Enabled = false;
                return;
            }

            var test = dgMemberListe.CurrentRow.DataBoundItem;
            if (test is Member selectedMember)
            {
                btnStartseiteBearbeiten.Enabled = true;
            }
            else
            {
                btnStartseiteBearbeiten.Enabled = false;
            }
        }

        private void EditMember(Member member)
        {
            frmUserVerwaltung frmUserVerwaltung = new frmUserVerwaltung();
            DialogResult result = frmUserVerwaltung.ShowAsDialog(member);
            if (result != DialogResult.OK)
            {
                return;
            }

            if (member.Id > 0)
            {
                Member? existingMember = _dataContext.Members.FirstOrDefault(m => m.Nr == member.Nr && m.Id != member.Id);
                if (existingMember != null)
                {
                    MessageBox.Show("Die Mitgliedsnummer ist bereits vergeben. Bitte eine andere Nummer wählen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EditMember(member);
                    return;
                }
                _dataContext.Members.Update(member);
            }
            else
            {
                Member? existingMember = _dataContext.Members.FirstOrDefault(m => m.Nr == member.Nr);
                if (existingMember != null)
                {
                    MessageBox.Show("Die Mitgliedsnummer ist bereits vergeben. Bitte eine andere Nummer wählen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EditMember(member);
                    return;
                }
                _dataContext.Members.Add(member);
            }

            _dataContext.SaveChanges();
            dgMemberListe.Refresh();
        }

        private void btnStartseiteLoeschen_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Wollen Sie den Eintrag wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var test = dgMemberListe.CurrentRow.DataBoundItem;
            if (test is Member selectedMember)
            {
                _dataContext.Members.Remove(selectedMember);
                _dataContext.SaveChanges();
                dgMemberListe.Refresh();
            }
        }

        private void btnStartseiteRefresh_Click(object sender, EventArgs e)
        {
            dgMemberListe.Refresh();
        }

        private void txtStartseiteNachname_TextChanged(object sender, EventArgs e)
        {
            // Filtert die Mitgliederliste basierend auf dem eingegebenen Nachnamen
            var filterText = txtStartseiteNachname.Text.ToLower();
            // Verwendet die lokale Ansicht der Mitglieder, um die Filterung durchzuführen
            var filteredMembers = _dataContext.Members.Local
                // Ignoriert Groß-/Kleinschreibung bei der Suche
                .Where(m => m.Nachname.ToLower().Contains(filterText))
                .ToList();

            // Aktualisiert die Datenquelle des BindingSource mit der gefilterten Liste
            _memberBindingSource.DataSource = filteredMembers;
            dgMemberListe.Refresh();
        }

        private void txtStartseiteName_TextChanged(object sender, EventArgs e)
        {
            var filterText = txtStartseiteName.Text.ToLower();
            var filteredMembers = _dataContext.Members.Local
                .Where(m => m.Vorname.ToLower().Contains(filterText))
                .ToList();

            _memberBindingSource.DataSource = filteredMembers;
            dgMemberListe.Refresh();
        }

        private void txtStartseiteMitgliederID_TextChanged(object sender, EventArgs e)
        {
            var filterText = txtStartseiteMitgliederID.Text.ToLower();
            var filteredMembers = _dataContext.Members.Local
                .Where(m => m.Nr.ToString().Contains(filterText))
                .ToList();

            _memberBindingSource.DataSource = filteredMembers;
            dgMemberListe.Refresh();
        }

        private void btnStartseiteExpo_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV-Datei (*.csv)|*.csv";
                saveFileDialog.Title = "CSV exportieren";
                saveFileDialog.FileName = "export.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDatagridViewToCSV(dgMemberListe, saveFileDialog.FileName);
                    MessageBox.Show("Export abgeschlossen");
                }
            }
        }

        public void ExportDatagridViewToCSV(DataGridView dgv, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                // Kopfzeile mit Spaltennamen schreiben 
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (i > 0) sw.Write(";");
                    sw.Write(dgv.Columns[i].HeaderText);
                }

                sw.WriteLine();

                // Zeilen schreiben
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        if (col > 0) sw.Write(";"); 
                        var val = dgv.Rows[row].Cells[col].Value;
                        sw.Write(val != null ? val?.ToString()?.Replace(',', ' ').Replace("\n", " ") : "");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
