using DartVerwaltung.Database;
using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace DartVerwaltung
{
    public partial class frmStartseite : Form
    {
        // Initialisiert den DataContext und BindingSource
        private DataContext _dataContext = new DataContext();
        private BindingSource _memberBindingSource = new BindingSource();

        private Form _form;

        public frmStartseite(Form form)
        {
            InitializeComponent();
            _form = form;

        }

        // Überschreibt die OnLoad-Methode, um Daten zu laden und das DataGridView zu binden
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dataContext.Members.Load();
            _memberBindingSource.DataSource = _dataContext.Members.Local.ToBindingList();
            dgMemberListe.DataSource = _memberBindingSource;
        }

        // Überschreibt die OnClosing-Methode, um den DataContext zu entsorgen
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _dataContext?.Dispose();

            _form.Close();
        }

        // Lädt Daten, wenn das Formular angezeigt wird
        /*
        private void Startseite_Shown(object sender, EventArgs e)
        {
            // Code Beispiel um Daten zu laden
            // Erstellt eine Liste aller Mitglieder in der Datenbank
            // List<Member> memberList = _dataContext.Members.ToList();
        }
        */

        // Öffnet das Formular zur Hinzufügung eines neuen Mitglieds
        private void btnStartseiteHinzufuegen_Click(object sender, EventArgs e)
        {
            frmUserVerwaltung frmUserVerwaltung = new frmUserVerwaltung();
            Member newMember = new Member();
            EditMember(newMember);
        }

        // Öffnet das Formular zur Anzeige von Clubstatistiken
        private void btnStartseiteAnzeigen_Click(object sender, EventArgs e)
        {
            frmClubStatistik frmClubStatistiken = new frmClubStatistik(_dataContext);
            frmClubStatistiken.ShowDialog();
        }

        // Öffnet das Formular zur Bearbeitung des ausgewählten Mitglieds
        private void btnStartseiteBearbeiten_Click(object sender, EventArgs e)
        {
            var test = dgMemberListe.CurrentRow.DataBoundItem;
            if (test is Member selectedMember)
            {
                EditMember(selectedMember);
            }
        }

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

        // Öffnet das Formular zur Bearbeitung eines Mitglieds und speichert die Änderungen
        private void EditMember(Member member)
        {
            frmUserVerwaltung frmUserVerwaltung = new frmUserVerwaltung();
            DialogResult result = frmUserVerwaltung.ShowAsDialog(member);
            if (result != DialogResult.OK)
            {
                return;
            }

            // Überprüft, ob die Mitgliedsnummer bereits vergeben ist
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

        // Löscht das ausgewählte Mitglied nach Bestätigung
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

        // Aktualisiert die Anzeige des DataGridView
        private void btnStartseiteRefresh_Click(object sender, EventArgs e)
        {
            dgMemberListe.Refresh();
        }

        // Filtert die Mitgliederliste basierend auf dem eingegebenen Nachnamen
        /*private void txtStartseiteNachname_TextChanged(object sender, EventArgs e)
        {
            var filterText = txtStartseiteNachname.Text.ToLower();
            var filteredMembers = _dataContext.Members.Local
                .Where(m => m.Nachname.ToLower().Contains(filterText))
                .ToList();

            _memberBindingSource.DataSource = filteredMembers;
            dgMemberListe.Refresh();
        }

        // Filtert die Mitgliederliste basierend auf dem eingegebenen Vornamen
        private void txtStartseiteName_TextChanged(object sender, EventArgs e)
        {
            var filterText = txtStartseiteName.Text.ToLower();
            var filteredMembers = _dataContext.Members.Local
                .Where(m => m.Vorname.ToLower().Contains(filterText))
                .ToList();

            _memberBindingSource.DataSource = filteredMembers;
            dgMemberListe.Refresh();
        }*/

        // Filtert die Mitgliederliste basierend auf der eingegebenen Mitgliedsnummer
        private void filterInput_Changed(object sender, EventArgs e)
        {
            var vornameFilter = txtStartseiteName.Text.ToLower();
            var numberFilter = txtStartseiteMitgliederID.Text.ToLower();
            var nachnameFilter = txtStartseiteNachname.Text.ToLower();
            var alterVonFilter = txtStartseiteAlterVon.Text.ToLower();
            var alterBisFilter = txtStartseiteAlterBis.Text.ToLower();


            var query = _dataContext.Members.AsQueryable();
            if (!string.IsNullOrEmpty(numberFilter))
            {
                query = query.Where(m => m.Nr.ToString().ToLower().Contains(numberFilter));
            }

            if (!string.IsNullOrEmpty(vornameFilter))
            {
                query = query.Where(m => m.Vorname.ToLower().Contains(vornameFilter));
            }

            if (!string.IsNullOrEmpty(nachnameFilter))
            {
                query = query.Where(m => m.Nachname.ToLower().Contains(nachnameFilter));
            }

            if (!string.IsNullOrEmpty(alterVonFilter))
            {
                DateTime? startDate = GetDateByAge(alterVonFilter, false);
                if(startDate != null)
                {
                    query = query.Where(m => m.Geburtstag.Date <= startDate);
                }
            }

            if (!string.IsNullOrEmpty(alterBisFilter))
            {
                DateTime? endDate = GetDateByAge(alterBisFilter, true);
                if(endDate != null)
                {
                    query = query.Where(m => m.Geburtstag.Date >= endDate);
                }
            }

            var filteredMembers = query.ToList();

            _memberBindingSource.DataSource = filteredMembers;
            dgMemberListe.Refresh();
        }

        private DateTime? GetDateByAge(string alterVonFilter, bool endDate)
        {
            if(!int.TryParse(alterVonFilter, out int age))
            {
                return null;
            }

            if(endDate)
            {
                return DateTime.Now.AddYears(-age - 1).AddDays(1).Date;
            }

            return DateTime.Now.AddYears(-age).Date;
        }



        // Exportiert die Daten des DataGridView in eine CSV-Datei
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

        // Methode zum Exportieren des DataGridView in eine CSV-Datei
        public void ExportDatagridViewToCSV(DataGridView dgv, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                // Kopfzeile schreiben
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (i > 0) sw.Write(";");
                    sw.Write(dgv.Columns[i].HeaderText);
                }

                sw.WriteLine();

                // Datenzeilen schreiben
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

        private void btnStartseiteSpielen_Click(object sender, EventArgs e)
        {
            frmPlayTime frmPlayTimes = new frmPlayTime();
            frmPlayTimes.ShowDialog();
        }

        private void frmStartseite_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
