using DartVerwaltung.Database;
using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DartVerwaltung
{
    public partial class frmStartseite : Form
    {
        // EF Core Datenbank verwaltet die Operationen
        private DataContext _dataContext = new DataContext();

        public frmStartseite()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dataContext.Members.Load();
            dgMemberListe.DataSource = _dataContext.Members.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _dataContext?.Dispose();
            _dataContext = null;
        }

        private void Startseite_Shown(object sender, EventArgs e)
        {
            // Fraglich ???

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
            frmClubStatistik frmClubStatistiken = new frmClubStatistik();
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
                _dataContext.Members.Update(member);
            }
            else
            {
                _dataContext.Members.Add(member);
            }

            _dataContext.SaveChanges();
            dgMemberListe.Refresh();
        }

        private void btnStartseiteLoeschen_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Wollen Sie den Eintrag wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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
    }
}
