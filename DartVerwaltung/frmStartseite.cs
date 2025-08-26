using DartVerwaltung.Database;
using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DartVerwaltung
{
    public partial class frmStartseite : Form
    {
        private DataContext _dataContext = new DataContext();

        public frmStartseite()
        {
            InitializeComponent();

            // Test, lädt die Database als Dataset(source)
            _dataContext.Members.Load<Member>();
            dgMemberListe.DataSource = _dataContext.Members.Local.ToBindingList();
            // Entfernt das angegebene Column
            dgMemberListe.Columns["Id"].Visible = false;
            dgMemberListe.Columns["Beruf"].Visible = false;
            dgMemberListe.Columns["Eintrittsdatum"].Visible = false;
            dgMemberListe.Columns["Austrittsdatum"].Visible = false;
            dgMemberListe.Columns["Familienstand"].Visible = false;
            dgMemberListe.Columns["Geburtstag"].Visible = false;
            dgMemberListe.Columns["Informationen"].Visible = false;
            dgMemberListe.Columns["Profilbild"].Visible = false;
            dgMemberListe.Columns["Profilbild"].Visible = false;
            dgMemberListe.Columns["Profilbild"].Visible = false;
        }

        private void Startseite_Shown(object sender, EventArgs e)
        {
            List<Member> memberList = _dataContext.Members.ToList();

        }

        private void btnStartseiteHinzufuegen_Click(object sender, EventArgs e)
        {
            frmUserVerwaltung frmUserVerwaltung = new frmUserVerwaltung();
            Member newMember = new Member();

            DialogResult result = frmUserVerwaltung.ShowAsDialog(newMember);
            if (result == DialogResult.OK)
            {
                _dataContext.Members.Add(newMember);
                _dataContext.SaveChanges();
            }
        }

        private void btnStartseiteAnzeigen_Click(object sender, EventArgs e)
        {
            frmMitgliederliste frmMitgliederliste = new frmMitgliederliste();
            frmMitgliederliste.ShowDialog();
        }
    }
}
